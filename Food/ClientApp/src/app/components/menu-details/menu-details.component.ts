import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Menu } from 'src/app/models/menu';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-menu-details',
  templateUrl: './menu-details.component.html',
  styleUrls: ['./menu-details.component.css']
})
export class MenuDetailsComponent {

  displayMenuName = {} as Menu;

  constructor(private _menuDetails:MenuService, private _route:ActivatedRoute) { }

  ngOnInit():void {
    const routeParams = this._route.snapshot.paramMap;
    let id: string | null = routeParams.get("id");

    if(id !== null) {

    this._menuDetails.GetName(id).subscribe((response:Menu) => {
      console.log(response);
      this.displayMenuName = response;
    });
  } else {
    console.error("The 'id' parameter is null. Handle this case accordingly.");
  }

  }
}
