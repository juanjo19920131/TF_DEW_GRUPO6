import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    template: ''
})

export class UserLogoutComponent implements OnInit {
    
    constructor(
        private router: Router
    ) {}

    ngOnInit(): void {
        sessionStorage.clear()
        
        this.router.navigateByUrl('/home', { skipLocationChange: false }).then(() => {
            this.router.navigate(['home']);
            window.location.reload();
        })
    }
}