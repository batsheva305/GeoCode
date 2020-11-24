import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { AddressService } from '../../services/address.service';

@Component({
  selector: 'app-find-coordinate',
  templateUrl: './find-coordinate.component.html',
  styleUrls: ['./find-coordinate.component.scss']
})
export class FindCoordinateComponent implements OnInit {

  constructor(private addressService: AddressService, private router: Router) { }

  ngOnInit(): void {
  }

  findCoordinate(address: string) {
    this.addressService.getCoordinates(address).subscribe(data=>
      {
        this.addressService.data = data;
        this.router.navigate(['/search-result']);
      });
    }

  }
