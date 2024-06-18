import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MessionComponent } from './Pages/mession/mession.component';

const routes: Routes = [

  { path: '', component: MessionComponent },
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
