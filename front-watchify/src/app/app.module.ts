import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeGuestModule } from './modules/home-guest/home-guest.module';
import { AdminService } from './Services/admin.service';
import { HttpClientModule } from '@angular/common/http';
import { EditUserComponent } from './modules/home-admin/components/edit-user/edit-user.component';
import { UserListComponent } from './modules/home-admin/components/user-list/user-list.component';
import { MatDialogActions, MatDialogClose, MatDialogContent, MatDialogModule, MatDialogTitle } from '@angular/material/dialog';

import {MatButtonModule} from '@angular/material/button';
import {FormsModule} from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
@NgModule({
  declarations: [
    AppComponent,
    EditUserComponent,
    UserListComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
   
    
  ],
  providers: [AdminService],
  bootstrap: [AppComponent]
})
export class AppModule { }
