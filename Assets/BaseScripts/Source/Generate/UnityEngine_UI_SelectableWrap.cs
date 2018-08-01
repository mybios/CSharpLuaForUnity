﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class UnityEngine_UI_SelectableWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Selectable), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("IsInteractable", IsInteractable);
		L.RegFunction("FindSelectable", FindSelectable);
		L.RegFunction("FindSelectableOnLeft", FindSelectableOnLeft);
		L.RegFunction("FindSelectableOnRight", FindSelectableOnRight);
		L.RegFunction("FindSelectableOnUp", FindSelectableOnUp);
		L.RegFunction("FindSelectableOnDown", FindSelectableOnDown);
		L.RegFunction("OnMove", OnMove);
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("OnPointerUp", OnPointerUp);
		L.RegFunction("OnPointerEnter", OnPointerEnter);
		L.RegFunction("OnPointerExit", OnPointerExit);
		L.RegFunction("OnSelect", OnSelect);
		L.RegFunction("OnDeselect", OnDeselect);
		L.RegFunction("Select", Select);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("allSelectables", get_allSelectables, null);
		L.RegFunction("getallSelectables", get_allSelectables);
		L.RegVar("navigation", get_navigation, set_navigation);
		L.RegFunction("getnavigation", get_navigation);
		L.RegFunction("setnavigation", set_navigation);
		L.RegVar("transition", get_transition, set_transition);
		L.RegFunction("gettransition", get_transition);
		L.RegFunction("settransition", set_transition);
		L.RegVar("colors", get_colors, set_colors);
		L.RegFunction("getcolors", get_colors);
		L.RegFunction("setcolors", set_colors);
		L.RegVar("spriteState", get_spriteState, set_spriteState);
		L.RegFunction("getspriteState", get_spriteState);
		L.RegFunction("setspriteState", set_spriteState);
		L.RegVar("animationTriggers", get_animationTriggers, set_animationTriggers);
		L.RegFunction("getanimationTriggers", get_animationTriggers);
		L.RegFunction("setanimationTriggers", set_animationTriggers);
		L.RegVar("targetGraphic", get_targetGraphic, set_targetGraphic);
		L.RegFunction("gettargetGraphic", get_targetGraphic);
		L.RegFunction("settargetGraphic", set_targetGraphic);
		L.RegVar("interactable", get_interactable, set_interactable);
		L.RegFunction("getinteractable", get_interactable);
		L.RegFunction("setinteractable", set_interactable);
		L.RegVar("image", get_image, set_image);
		L.RegFunction("getimage", get_image);
		L.RegFunction("setimage", set_image);
		L.RegVar("animator", get_animator, null);
		L.RegFunction("getanimator", get_animator);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsInteractable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			var o = obj.IsInteractable();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			var o = obj.FindSelectable(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnLeft(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			var o = obj.FindSelectableOnLeft();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnRight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			var o = obj.FindSelectableOnRight();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			var o = obj.FindSelectableOnUp();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			var o = obj.FindSelectableOnDown();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)ToLua.CheckObject<UnityEngine.EventSystems.AxisEventData>(L, 2);
			obj.OnMove(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerUp(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerEnter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerEnter(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerExit(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnSelect(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeselect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnDeselect(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Select(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.UI.Selectable)ToLua.CheckObject<UnityEngine.UI.Selectable>(L, 1);
			obj.Select();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_allSelectables(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, UnityEngine.UI.Selectable.allSelectables);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_navigation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Navigation ret = obj.navigation;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index navigation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Selectable.Transition ret = obj.transition;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colors(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.ColorBlock ret = obj.colors;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colors on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spriteState(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.SpriteState ret = obj.spriteState;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spriteState on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animationTriggers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.AnimationTriggers ret = obj.animationTriggers;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index animationTriggers on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetGraphic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Graphic ret = obj.targetGraphic;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetGraphic on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_interactable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			bool ret = obj.interactable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index interactable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_image(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Image ret = obj.image;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index image on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animator(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.Animator ret = obj.animator;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index animator on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_navigation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Navigation arg0 = StackTraits<UnityEngine.UI.Navigation>.Check(L, 2);
			obj.navigation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index navigation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_transition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Selectable.Transition arg0 = (UnityEngine.UI.Selectable.Transition)LuaDLL.luaL_checknumber(L, 2);
			obj.transition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colors(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.ColorBlock arg0 = StackTraits<UnityEngine.UI.ColorBlock>.Check(L, 2);
			obj.colors = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colors on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spriteState(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.SpriteState arg0 = StackTraits<UnityEngine.UI.SpriteState>.Check(L, 2);
			obj.spriteState = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spriteState on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_animationTriggers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.AnimationTriggers arg0 = (UnityEngine.UI.AnimationTriggers)ToLua.CheckObject<UnityEngine.UI.AnimationTriggers>(L, 2);
			obj.animationTriggers = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index animationTriggers on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetGraphic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Graphic arg0 = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 2);
			obj.targetGraphic = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetGraphic on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_interactable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.interactable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index interactable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_image(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckObject<UnityEngine.UI.Image>(L, 2);
			obj.image = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index image on a nil value");
		}
	}
}
