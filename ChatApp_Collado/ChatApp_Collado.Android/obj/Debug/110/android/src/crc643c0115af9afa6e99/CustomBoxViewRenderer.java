package crc643c0115af9afa6e99;


public class CustomBoxViewRenderer
	extends crc643f46942d9dd1fff9.BoxRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("ChatApp_Collado.Droid.CustomRenderers.CustomBoxViewRenderer, ChatApp_Collado.Android", CustomBoxViewRenderer.class, __md_methods);
	}


	public CustomBoxViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomBoxViewRenderer.class)
			mono.android.TypeManager.Activate ("ChatApp_Collado.Droid.CustomRenderers.CustomBoxViewRenderer, ChatApp_Collado.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomBoxViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomBoxViewRenderer.class)
			mono.android.TypeManager.Activate ("ChatApp_Collado.Droid.CustomRenderers.CustomBoxViewRenderer, ChatApp_Collado.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomBoxViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomBoxViewRenderer.class)
			mono.android.TypeManager.Activate ("ChatApp_Collado.Droid.CustomRenderers.CustomBoxViewRenderer, ChatApp_Collado.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
