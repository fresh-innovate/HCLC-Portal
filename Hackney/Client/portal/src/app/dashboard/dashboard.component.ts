import { Component, OnInit} from "@angular/core";
import { ROUTER_DIRECTIVES } from '@angular/router';

@Component({
    templateUrl: '/portal/app/dashboard/dashboard.component.html',
    directives: [ ROUTER_DIRECTIVES ]
})
export class DashboardComponent implements OnInit {
    constructor() { }
    ngOnInit() {
    }
}