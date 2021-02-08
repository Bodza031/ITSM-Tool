import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() usersFromHomeComponent: any;
  @Output() cancelRegister = new EventEmitter();
  model : any = {}

  constructor(private AccountService: AccountService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  register () {
    this.AccountService.register(this.model).subscribe(response => {
      console.log(response);
      this.cancle();
    }, error =>{
      console.log(error);
      this.toastr.error(error.error)
    })
  }

  cancle(){
    this.cancelRegister.emit(false);
  }
}
