/* Global variables */
import { install } from 'riot';

export var posts = []

export var storage = {
    init: function() {
        if (localStorage.getItem('posts') === 'undefined' || localStorage.getItem('posts') == null) {
            localStorage.setItem('posts', '[]');
        }

        posts = JSON.parse(localStorage.getItem('posts'));

    },

    getPost: function(Component) {
        if (Component.props && Component.props.index) {
            for (var i in posts) {
                if (posts[i].index === Component?.props?.index) {
                    Component.post = posts[i];
                    Component.post.index = i;
                }
            }
        }
    },

    delete: function(postParam) {
        let removedPosts = posts.splice(postParam.index,1);
        let posts_str = JSON.stringify(removedPosts);
        localStorage.setItem('posts', posts_str);
    },

    insert: function(postParam)
    {
        let lastIndex = posts && posts?.length - 1 > 0?posts.length - 1:0;
        postParam.index = lastIndex+1;
        posts.push(postParam);
        let posts_str = JSON.stringify(posts);
        localStorage.setItem('posts', posts_str);
    },

    update: function(postParam)
    {
        posts[postParam.index] = postParam;
        let posts_str = JSON.stringify(posts);
        localStorage.setItem('posts', posts_str);
    }
}


install(function(component) {
    component.posts = posts;
    component.storage = storage;
    return component;
})