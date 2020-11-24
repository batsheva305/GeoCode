import { Component, OnInit } from '@angular/core';
import { AddressService } from '../../services/address.service';
import { Address } from '../../models/address';

@Component({
  selector: 'app-search-result',
  templateUrl: './search-result.component.html',
  styleUrls: ['./search-result.component.scss']
})
export class SearchResultComponent implements OnInit {
  
  coordinateResult: Address;
  popularSearchResult: Address;

  constructor(private addressService: AddressService) { }

  ngOnInit(): void {
    this.coordinateResult = this.addressService.data;
    this.addressService.data = undefined;

    this.addressService.getPopularSearch(1).subscribe(address=>this.popularSearchResult=address[0]);
  }

}
