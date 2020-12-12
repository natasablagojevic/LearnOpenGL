#version 330 core
out vec4 FragColor;

// TODO Linearize depth coordinate

void main()
{             
    float depth = gl_FragCoord.z;
    FragColor = vec4(vec3(depth), 1.0);
}