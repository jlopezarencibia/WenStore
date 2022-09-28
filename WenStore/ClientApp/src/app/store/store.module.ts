import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ItemAddComponent} from './items/item-add/item-add.component';
import {RouterModule} from '@angular/router';
import {StoreComponent} from './store.component';
import {FormsModule} from "@angular/forms";


@NgModule({
  declarations: [
    ItemAddComponent,
    StoreComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path: '', component: StoreComponent}]),
    FormsModule
  ]
})
export class StoreModule {
}
