import { Component, OnInit } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';
import { FormGroup, FormBuilder, FormsModule, FormControl, Validators, ReactiveFormsModule } from '@angular/forms';
import { AbstractControl } from '@angular/forms';
import { Router, ActivatedRoute, Params } from '@angular/router';
import * as $ from 'jquery';

@Component({
    selector: 'quote-form',
    templateUrl: './form.quote.html',
    styleUrls: ['./form.quote.css']
})


export class QuoteFormComponent implements OnInit {
    quoteForm: FormGroup;
    petAges: PetAge[];
    breeds: Breed[];
    petId: number = 2;
    isMale: boolean = true;
    titleColor: string = 'white';
    display: string = 'none';
    selectedPetAge: string;

    constructor(private http: Http, fb: FormBuilder, private router: Router, private activateRoute: ActivatedRoute) {
        this.quoteForm = fb.group({
            petName: new FormControl('', Validators.required),
            petType: new FormControl(''),
            isMale: new FormControl(''),
            petAge: new FormControl('', Validators.required),
            breed: new FormControl('', Validators.required),
            zipCode: new FormControl('', [Validators.required, Validators.pattern('^[0-9]{5}(?:-[0-9]{4})?$')]),
            email: new FormControl('', Validators.email)
        });

        this.activateRoute.params.subscribe(params => {
            if (params.color) {
                this.titleColor = '#' + params.color;
            }
        });
    }
    ngOnInit() {
        this.getPetAges();
        this.getBreed();
    }

    submitQuoteForm() {
        if (this.quoteForm.valid) {
            
            let myheaders = new Headers();
            myheaders.append('Content-Type', 'application/json');
            myheaders.append('Accept', 'application/json');

            let token: any = $("input[name=__RequestVerificationToken]").val();

            if (token !== null) {
                myheaders.append('RequestVerificationToken', token);
            }
            
            let options = new RequestOptions({ headers: myheaders });

            return this.http.post('/quote/index', JSON.stringify(this.quoteForm.value), options)
                .subscribe(res => {
                    var result = res.json();
                    if (result.success) {
                        this.router.navigateByUrl('/confirmation');
                    }
                },
                err => {
                    console.log('Error Occured');
                });
        }
    }

    onPetAgeChange() {
        if (this.quoteForm.value && this.quoteForm.value.petAge === "0 - 7 weeks old") {
            this.display = 'block';
        }
    }

    getBreed() {
        this.http.get('/quote/getbreed' + '?petType=' + this.petId).subscribe(values => {
            this.breeds = values.json();
        });
    }

    getPetAges() {
        this.http.get('/quote/getpetages').subscribe(values => {
            this.petAges = values.json();
            //setTimeout(function () {
                
            //}, 2000);
        });
    }

    onCloseHandled() {
        this.display = 'none';
        if (this.quoteForm && this.quoteForm.value && this.petAges) {
            //this.getPetAges();
            $('.selectPetAge option:eq(0)').prop('selected', true);
        }
    }

    onOpenHandled() {
        this.display = 'block';
    }
}

export class PetAge {
    public Age: string;
    public Id: number;
}

export class Breed {
    public BreedName: string;
    public PetId: number;
    public PetType: number;
}
