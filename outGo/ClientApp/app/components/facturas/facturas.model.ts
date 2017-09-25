export interface Facturas {
    id: number;
    id_comercio: number;
    fecha: string;
    monto_pesos: number;
    monto_dolares: number;
    comision_dolares: number;
    detalles: string;
}