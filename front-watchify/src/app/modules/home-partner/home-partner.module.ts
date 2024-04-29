import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomePartnerRoutingModule } from './home-partner-routing.module';
import { HomeComponent } from './home/home.component';
import { NavbarpartComponent } from './navbarpart/navbarpart.component';
import { AddfilmComponent } from './addfilm/addfilm.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    HomeComponent,
    NavbarpartComponent,
    AddfilmComponent
  ],
  imports: [
    CommonModule,
    HomePartnerRoutingModule,
    FormsModule,
    ReactiveFormsModule

  ]
})
export class HomePartnerModule { }
