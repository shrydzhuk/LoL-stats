import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SummonersMatchesComponent } from './pages/summoners-matches/summoners-matches.component';

const routes: Routes = [
  {
    path: '',
    component: SummonersMatchesComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
