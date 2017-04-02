import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ArticleViewModel } from './article-view-models'

@Component({
    selector: 'article-list',
    templateUrl: 'article-list.component.html'
})
export class ArticleListComponent implements OnInit {
    public article: ArticleViewModel;

    constructor(http: Http) {
        http.get('/api/articles/' + ).subscribe(result => {
            this.article = result.json() as ArticleViewModel;
        });
    }

    ngOnInit() {

    }
}