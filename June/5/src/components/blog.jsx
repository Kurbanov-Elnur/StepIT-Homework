import React from 'react';

const BlogPosts = ({ posts }) => {
    return (
        <div className="blog-posts">
            {posts.map((post, index) => (
                <div key={index} className="post">
                    <h2>{post.title}</h2>
                    <p>{post.content}</p>
                    <p><strong>Published on:</strong> {new Date(post.date).toLocaleDateString()}</p>
                    <div className="tags">
                        {post.tags.map((tag, idx) => (
                            <span key={idx} className="tag">{tag}</span>
                        ))}
                    </div>
                </div>
            ))}
        </div>
    );
};

export default BlogPosts;