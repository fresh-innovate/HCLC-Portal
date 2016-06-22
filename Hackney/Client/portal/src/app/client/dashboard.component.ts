import { Component, OnInit} from "@angular/core";
import { ROUTER_DIRECTIVES } from '@angular/router';

@Component({
    templateUrl: '/portal/app/client/dashboard.component.html',
    directives: [ ROUTER_DIRECTIVES ]
})
export class ClientDashboardComponent implements OnInit {
    constructor() { }
    ngOnInit() {
    }
}