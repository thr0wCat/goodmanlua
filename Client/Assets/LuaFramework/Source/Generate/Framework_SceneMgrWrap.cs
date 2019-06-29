﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_SceneMgrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.SceneMgr), typeof(Framework.Singleton<Framework.SceneMgr>));
		L.RegFunction("TransToScene", TransToScene);
		L.RegFunction("New", _CreateFramework_SceneMgr);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("CurScene", get_CurScene, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFramework_SceneMgr(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SceneMgr.ctor");
#endif
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Framework.SceneMgr obj = new Framework.SceneMgr();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Framework.SceneMgr.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransToScene(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SceneMgr.TransToScene");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.SceneMgr obj = (Framework.SceneMgr)ToLua.CheckObject<Framework.SceneMgr>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			Framework.SceneLoadEventHandler arg1 = (Framework.SceneLoadEventHandler)ToLua.CheckDelegate<Framework.SceneLoadEventHandler>(L, 3);
			System.Collections.Generic.IEnumerator<float> o = obj.TransToScene(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurScene(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SceneMgr.CurScene");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.SceneMgr obj = (Framework.SceneMgr)o;
			Framework.Scene ret = obj.CurScene;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CurScene on a nil value");
		}
	}
}

