export class Address {
  addressString: string;
  latitude: number;
  longitude: number;
  numberOfHits:number;

  constructor(address:string, latitude:number, longitude:number, numberOfHits:number) {
    this.addressString=address;
    this.latitude=latitude;
    this.longitude=longitude;
    this.numberOfHits=numberOfHits;
  }
}
