import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home/home.component';
import { SehirlisteComponent } from './sehir/sehirliste/sehirliste.component';

const routes: Routes = [
  {path: 'home', component : HomeComponent},
  {path: 'slist', component : SehirlisteComponent},
  {path: '', redirectTo: '/home', pathMatch : 'full'},
  {path: '**' , component : HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
