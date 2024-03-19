using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextView
	/// </summary>
	/// <remarks>
	///    provides a view of the vtkContextScene.
	///
	///
	/// This class is derived from vtkRenderViewBase and provides a view of a
	/// vtkContextScene, with a default interactor style, renderer etc. It is
	/// the simplest way to create a vtkRenderWindow and display a 2D scene inside
	/// of it.
	///
	/// By default the scene has a white background.
	/// </remarks>
	// Token: 0x02000058 RID: 88
	public class vtkContextView : vtkRenderViewBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000FF0 RID: 4080 RVA: 0x0001CEF7 File Offset: 0x0001B0F7
		static vtkContextView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000FF1 RID: 4081 RVA: 0x0001CF1F File Offset: 0x0001B11F
		public vtkContextView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000FF2 RID: 4082 RVA: 0x0001CF2D File Offset: 0x0001B12D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000FF3 RID: 4083
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextView_GetContext_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkContext2D for the view.
		/// </summary>
		// Token: 0x06000FF4 RID: 4084 RVA: 0x0001CF38 File Offset: 0x0001B138
		public virtual vtkContext2D GetContext()
		{
			vtkContext2D vtkContext2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextView.vtkContextView_GetContext_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000FF5 RID: 4085
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextView_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FF6 RID: 4086 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextView.vtkContextView_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06000FF7 RID: 4087
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextView_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FF8 RID: 4088 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextView.vtkContextView_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06000FF9 RID: 4089
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextView_GetScene_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the scene of the view.
		/// </summary>
		// Token: 0x06000FFA RID: 4090 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		public virtual vtkContextScene GetScene()
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextView.vtkContextView_GetScene_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000FFB RID: 4091
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextView_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FFC RID: 4092 RVA: 0x0001D054 File Offset: 0x0001B254
		public override int IsA(string type)
		{
			return vtkContextView.vtkContextView_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06000FFD RID: 4093
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextView_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FFE RID: 4094 RVA: 0x0001D074 File Offset: 0x0001B274
		public new static int IsTypeOf(string type)
		{
			return vtkContextView.vtkContextView_IsTypeOf_06(type);
		}

		// Token: 0x06000FFF RID: 4095
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextView_New_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001000 RID: 4096 RVA: 0x0001D090 File Offset: 0x0001B290
		public new static vtkContextView New()
		{
			vtkContextView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextView.vtkContextView_New_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06001001 RID: 4097
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextView_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001002 RID: 4098 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
		public new vtkContextView NewInstance()
		{
			vtkContextView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextView.vtkContextView_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06001003 RID: 4099
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextView_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001004 RID: 4100 RVA: 0x0001D140 File Offset: 0x0001B340
		public new static vtkContextView SafeDownCast(vtkObjectBase o)
		{
			vtkContextView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextView.vtkContextView_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06001005 RID: 4101
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextView_SetContext_10(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Set the vtkContext2D for the view.
		/// </summary>
		// Token: 0x06001006 RID: 4102 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		public virtual void SetContext(vtkContext2D context)
		{
			vtkContextView.vtkContextView_SetContext_10(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		// Token: 0x06001007 RID: 4103
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextView_SetScene_11(HandleRef pThis, HandleRef scene);

		/// <summary>
		/// Set the scene object for the view.
		/// </summary>
		// Token: 0x06001008 RID: 4104 RVA: 0x0001D1DC File Offset: 0x0001B3DC
		public virtual void SetScene(vtkContextScene scene)
		{
			vtkContextView.vtkContextView_SetScene_11(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000432 RID: 1074
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000433 RID: 1075
		public new static readonly string MRClassNameKey = "class vtkContextView";
	}
}
