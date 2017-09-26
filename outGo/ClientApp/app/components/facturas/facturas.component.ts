import { Component, OnInit } from '@angular/core';
import { FacturasService } from './facturas.service';
import { Facturas } from './facturas.model';

@Component({
    selector: 'app-facturas',
    templateUrl: './facturas.component.html'
})

export class FacturasComponent  {
    public facturas:any;

    constructor(private facturasService: FacturasService) {
        this.facturasService.get()
            .then(data => this.facturas = data)
            .then(function (data) { console.log(data); });

            
    }
}
