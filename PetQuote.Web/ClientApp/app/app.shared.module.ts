import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
//import { MatDialogModule } from '@angular/material'

import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/header/app.header';
import { FooterComponent } from './components/footer/app.footer';
import { QuoteFormComponent } from './components/pages/quote/form.quote';
import { QuoteConfirmationComponent } from './components/pages/quote/confirmation/quote.confirmation';
import { AppSocialMediaComponent } from './components/ui-controls/app.social.media';


@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        HeaderComponent,
        FooterComponent,
        QuoteFormComponent,
        QuoteConfirmationComponent,
        AppSocialMediaComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,
        //MatDialogModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'quote', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'quote', component: QuoteFormComponent },
            { path: 'quote/:color', component: QuoteFormComponent },
            { path: 'confirmation', component: QuoteConfirmationComponent },
            { path: '**', redirectTo: 'quote' }
        ])
    ]
})
export class AppModuleShared {
}
