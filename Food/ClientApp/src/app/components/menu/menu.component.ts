import { Component } from '@angular/core';
import { Menu } from 'src/app/models/menu';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent {
  menuResult: Menu[] = [];
  foodName: Menu = {} as Menu;
  item: string = "";

  constructor(private _menuService: MenuService) {}

  ngOnInit():void {
    this.GetMenu();
    this.GetMenuName(this.item);
  }

  GetMenu(){
    this._menuService.GetFoods().subscribe((response: Menu[]) => {
      console.log(response);
      this.menuResult = response;
    });
  }

  GetMenuName(name:string){
    this._menuService.GetName(name).subscribe((response: Menu) =>{
      console.log(response);
      this.foodName = response;
    });
  }

  DeleteMenuName(name:string):void {
    let target: number = this.menuResult.findIndex((m) => m.name == name);
    this.menuResult.splice(target, 1);

    this._menuService.DeleteName(name).subscribe((response: Menu) => {
      console.log(response);
    });
  }
}
