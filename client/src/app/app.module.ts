import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ApiService } from './services/api.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NbButtonModule, NbCardModule, NbGlobalPhysicalPosition, NbInputModule, NbLayoutModule, NbSelectModule, NbThemeModule, NbToastrModule } from '@nebular/theme';
import { NbEvaIconsModule } from '@nebular/eva-icons';
import { HeaderComponent } from './components/header/header.component';
import { SummonersMatchesComponent } from './pages/summoners-matches/summoners-matches.component';
import { MatchesListComponent } from './components/matches-list/matches-list.component';
import { MatchDetailsComponent } from './components/match-details/match-details.component';
import { DurationPipe } from './pipes/duration.pipe';
import { TimeSincePipe } from './pipes/timeSince.pipe';

const toastrConfig = {
  duration: 5000,
  position: NbGlobalPhysicalPosition.TOP_RIGHT,
  preventDuplicates: true,
};

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SummonersMatchesComponent,
    MatchesListComponent,
    MatchDetailsComponent,
    DurationPipe,
    TimeSincePipe
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NbThemeModule.forRoot({ name: 'dark' }),
    NbLayoutModule,
    NbEvaIconsModule,
    NbCardModule,
    NbInputModule,
    NbSelectModule,
    NbButtonModule,
    NbToastrModule.forRoot(toastrConfig),
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
