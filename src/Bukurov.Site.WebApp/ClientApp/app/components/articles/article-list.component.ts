import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'article-list',
    templateUrl: 'article-list.component.html'
})
export class ArticleListComponent {
    public articles: ArticleModel[];

    constructor(http: Http) {
        http.get('/api/articles').subscribe(result => {
            this.articles = result.json() as ArticleModel[];
        });
    }
}

interface ArticleModel {
    id: string,
    title: string,
    content: string
}