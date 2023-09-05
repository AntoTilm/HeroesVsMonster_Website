import {Component, OnInit} from '@angular/core';
import {MovieService} from "../../shared/services/movie.service";
import {MovieItem} from "../../shared/models/movie";
import {Router} from "@angular/router";

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.page.html',
  styleUrls: ['./movie-list.page.scss'],
})
export class MovieListPage implements OnInit {

  constructor(private _movieService: MovieService, private _router: Router) {
    _movieService.getMovieDetail('taxi')
  }

  inputValue: string = '';

  movies: string[] = []

  ngOnInit() {
  }

  refreshMovieList(event: any) {
    this._movieService.searchMovies(this.inputValue).subscribe(movies => {
      this.movies = [];
      movies.Search.forEach(movie => {
        this.movies.push(movie.title);
      })
    })
  }

  getMovieDetail(title: string): void {
    this._movieService.getMovieDetail(title).subscribe(data => {
      this._movieService.selectedMovie = {
        Rating : data.Rating,
        Plot : data.Plot,
        Poster : data.Poster,
        Title : data.Title
      }
    })
    this._router.navigateByUrl('movie-details')
  }

}
