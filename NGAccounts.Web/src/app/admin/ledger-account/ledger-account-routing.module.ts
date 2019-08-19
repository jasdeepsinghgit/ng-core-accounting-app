import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LedgerAccountComponent } from './ledger-account.component';

const routes: Routes = [{
  path: '',
  component: LedgerAccountComponent
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LedgerAccountRoutingModule { }

