import React from 'react';
import Post from './post';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  loadPosts = () => {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(res => res.json())
      .then(data => {
        const postList = data.map(
          item => new Post(item.id, item.title, item.body)
        );
        this.setState({ posts: postList });
      })
      .catch(error => {
        console.error("Failed to load posts:", error);
        this.setState({ hasError: true });
      });
  };

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    alert("An error occurred while rendering posts.");
    console.error("Error info:", info);
    this.setState({ hasError: true });
  }

  render() {
    if (this.state.hasError) {
      return <h2>Something went wrong while loading posts.</h2>;
    }

    return (
      <div style={{ padding: '0px 50px', fontFamily: 'Arial' }}>
        <h2 style={{ marginBottom: '20px' }}>Posts</h2>
        {this.state.posts.map(post => (
          <div
            key={post.id}
            style={{
                border: '1px solid #ddd',
                padding: '5px',
                marginBottom: '10px',
                borderRadius: '8px',
                backgroundColor: '#f9f9f9'
            }}
          >
            <h3 style={{ color: '#3780c9ff' }}>
              #{post.id} - {post.title}
            </h3>
            <p style={{ color: '#137c4bff' }}>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
