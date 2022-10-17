import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-summoners-matches',
  templateUrl: './summoners-matches.component.html',
  styleUrls: ['./summoners-matches.component.scss']
})
export class SummonersMatchesComponent implements OnInit {
  public name: string = '';
  public matchesCount: number = 5;

  constructor() { }

  ngOnInit(): void {
  }

  getMatches(name: string): void {
    // TODO: Get Matches using Api Service.
  }

}
