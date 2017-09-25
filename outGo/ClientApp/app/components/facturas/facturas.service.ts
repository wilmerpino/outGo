import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/Rx';
import { Facturas } from './facturas.model';

@Injectable()
export class FacturasService{
    private facturas: Facturas;

    constructor(private http: Http) {

    }


    get() {
        return this.http.get('http://localhost:50785/api/facturas')
            .map(response => response.json() as Facturas[])
            .toPromise();	
    }
}