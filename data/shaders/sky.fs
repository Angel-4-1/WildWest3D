//fragment shader for displaying the sky
varying vec3 v_direction;

varying vec3 v_position;
varying vec3 v_world_position;
varying vec3 v_normal;
varying vec2 v_uv;
varying vec4 v_color;

uniform samplerCube u_skybox;

void main()
{
	//vec2 uv = v_uv;
	//gl_FragColor = u_color * texture2D( u_texture, uv );

	gl_FragColor = textureCube(u_skybox, v_direction);
}


