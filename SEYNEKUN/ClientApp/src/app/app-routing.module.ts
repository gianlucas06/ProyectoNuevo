import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PanelaRegistroComponent } from './Produccion/panela-registro/panela-registro.component';
import { PanelaConsultaComponent } from './Produccion/panela-consulta/panela-consulta.component';
import { Routes, RouterModule } from '@angular/router';
import { LogginComponent } from './loggin/loggin.component';
import {ConocenosComponent} from './conocenos/conocenos.component';
import{ProductorRegistroComponent} from './Productor/productor-registro/productor-registro.component';


const routes: Routes = [
  {
    path: 'productorRegistro',
    component: ProductorRegistroComponent
    },
  {
  path: 'panelaRegistro',
  component: PanelaRegistroComponent
  },

  {
    path: 'panelaConsulta',
    component: PanelaConsultaComponent
  },
  {
    path: 'loggin',
    component: LogginComponent
  },
  {
    path: 'conocenos',
    component: ConocenosComponent
  }
];



@NgModule({
  declarations: [],
  imports: [
    CommonModule,RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }

