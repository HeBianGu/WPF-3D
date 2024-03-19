using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextActor
	/// </summary>
	/// <remarks>
	///    provides a vtkProp derived object.
	///
	/// This object provides the entry point for the vtkContextScene to be rendered
	/// in a vtkRenderer. Uses the RenderOverlay pass to render the 2D
	/// vtkContextScene.
	/// </remarks>
	// Token: 0x0200011E RID: 286
	public class vtkContextActor : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003A8F RID: 14991 RVA: 0x0005515B File Offset: 0x0005335B
		static vtkContextActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003A90 RID: 14992 RVA: 0x00055183 File Offset: 0x00053383
		public vtkContextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003A91 RID: 14993
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A92 RID: 14994 RVA: 0x00055194 File Offset: 0x00053394
		public new static vtkContextActor New()
		{
			vtkContextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextActor.vtkContextActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A93 RID: 14995 RVA: 0x000551E8 File Offset: 0x000533E8
		public vtkContextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextActor.vtkContextActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003A94 RID: 14996 RVA: 0x0005522C File Offset: 0x0005342C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003A95 RID: 14997
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextActor_GetContext_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkContext2D for the actor.
		/// </summary>
		// Token: 0x06003A96 RID: 14998 RVA: 0x00055238 File Offset: 0x00053438
		public virtual vtkContext2D GetContext()
		{
			vtkContext2D vtkContext2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextActor.vtkContextActor_GetContext_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContext2D = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContext2D.Register(null);
				}
			}
			return vtkContext2D;
		}

		// Token: 0x06003A97 RID: 14999
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextActor_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A98 RID: 15000 RVA: 0x000552A8 File Offset: 0x000534A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextActor.vtkContextActor_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003A99 RID: 15001
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextActor_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A9A RID: 15002 RVA: 0x000552C8 File Offset: 0x000534C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextActor.vtkContextActor_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003A9B RID: 15003
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextActor_GetScene_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the chart object for the actor.
		/// </summary>
		// Token: 0x06003A9C RID: 15004 RVA: 0x000552E4 File Offset: 0x000534E4
		public vtkContextScene GetScene()
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextActor.vtkContextActor_GetScene_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextScene = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextScene.Register(null);
				}
			}
			return vtkContextScene;
		}

		// Token: 0x06003A9D RID: 15005
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextActor_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A9E RID: 15006 RVA: 0x00055354 File Offset: 0x00053554
		public override int IsA(string type)
		{
			return vtkContextActor.vtkContextActor_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003A9F RID: 15007
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextActor_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AA0 RID: 15008 RVA: 0x00055374 File Offset: 0x00053574
		public new static int IsTypeOf(string type)
		{
			return vtkContextActor.vtkContextActor_IsTypeOf_06(type);
		}

		// Token: 0x06003AA1 RID: 15009
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextActor_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AA2 RID: 15010 RVA: 0x00055390 File Offset: 0x00053590
		public new vtkContextActor NewInstance()
		{
			vtkContextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextActor.vtkContextActor_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003AA3 RID: 15011
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextActor_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003AA4 RID: 15012 RVA: 0x000553EC File Offset: 0x000535EC
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkContextActor.vtkContextActor_ReleaseGraphicsResources_09(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06003AA5 RID: 15013
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextActor_RenderOverlay_10(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// We only render in the overlay for the context scene.
		/// </summary>
		// Token: 0x06003AA6 RID: 15014 RVA: 0x0005541C File Offset: 0x0005361C
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkContextActor.vtkContextActor_RenderOverlay_10(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06003AA7 RID: 15015
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextActor_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003AA8 RID: 15016 RVA: 0x00055450 File Offset: 0x00053650
		public new static vtkContextActor SafeDownCast(vtkObjectBase o)
		{
			vtkContextActor vtkContextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextActor.vtkContextActor_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextActor = (vtkContextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextActor.Register(null);
				}
			}
			return vtkContextActor;
		}

		// Token: 0x06003AA9 RID: 15017
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextActor_SetScene_12(HandleRef pThis, HandleRef scene);

		/// <summary>
		/// Set the scene for the actor.
		/// </summary>
		// Token: 0x06003AAA RID: 15018 RVA: 0x000554D0 File Offset: 0x000536D0
		public void SetScene(vtkContextScene scene)
		{
			vtkContextActor.vtkContextActor_SetScene_12(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000675 RID: 1653
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000676 RID: 1654
		public new static readonly string MRClassNameKey = "class vtkContextActor";
	}
}
