import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgSelectModule } from '@ng-select/ng-select';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MessionTicketComponent } from './ShereComponents/mession-ticket/mession-ticket.component';
import { MessionComponent } from './Pages/mession/mession.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpService } from './Services/http.service';
import { OpenMessionsComponent } from './ShereComponents/open-messions/open-messions.component';

@NgModule({
  declarations: [
    AppComponent,
    MessionTicketComponent,
    MessionComponent,
    OpenMessionsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    NgSelectModule,
    HttpClientModule
  ],
  providers: [HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
