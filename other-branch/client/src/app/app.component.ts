import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Dating Start '; 
  users: any;
  constructor(private http: HttpClient) {}

  ngOnInit(){
    this.getUserDetails();
  }

  getUserDetails(){
    this.http.get('https://localhost:5001/api/Users').subscribe(response =>{
      this.users = response;
    }), error=>{
      console.log('Error Occured');
    };
  }

}




