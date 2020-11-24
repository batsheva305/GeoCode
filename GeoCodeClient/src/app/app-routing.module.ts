import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FindCoordinateComponent } from './components/find-coordinate/find-coordinate.component';
import { SearchResultComponent } from './components/search-result/search-result.component';

const routes: Routes = [
  { path: 'search', component: FindCoordinateComponent },
  { path: 'search-result', component: SearchResultComponent },
  {path: '',   redirectTo: '/search', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
