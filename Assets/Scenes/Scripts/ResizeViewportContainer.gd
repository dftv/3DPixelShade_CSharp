extends SubViewportContainer

#Public

#Private
var scaling3DScale = 0.25;

#External
var _subViewport;

func _ready():
	_subViewport = get_node("SubViewport");;
	
	_subViewport.scaling_3d_scale = scaling3DScale;
