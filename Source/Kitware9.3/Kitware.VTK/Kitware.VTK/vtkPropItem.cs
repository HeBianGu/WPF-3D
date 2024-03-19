using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPropItem
	/// </summary>
	/// <remarks>
	///    Embed a vtkProp in a vtkContextScene.
	///
	///
	/// This class allows vtkProp objects to be drawn inside a vtkContextScene.
	/// This is especially useful for constructing layered scenes that need to ignore
	/// depth testing.
	/// </remarks>
	// Token: 0x02000124 RID: 292
	public class vtkPropItem : vtkAbstractContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003BB7 RID: 15287 RVA: 0x00056D27 File Offset: 0x00054F27
		static vtkPropItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPropItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003BB8 RID: 15288 RVA: 0x00056D4F File Offset: 0x00054F4F
		public vtkPropItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003BB9 RID: 15289
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BBA RID: 15290 RVA: 0x00056D60 File Offset: 0x00054F60
		public new static vtkPropItem New()
		{
			vtkPropItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropItem.vtkPropItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BBB RID: 15291 RVA: 0x00056DB4 File Offset: 0x00054FB4
		public vtkPropItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPropItem.vtkPropItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003BBC RID: 15292 RVA: 0x00056DF8 File Offset: 0x00054FF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003BBD RID: 15293
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BBE RID: 15294 RVA: 0x00056E04 File Offset: 0x00055004
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPropItem.vtkPropItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003BBF RID: 15295
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BC0 RID: 15296 RVA: 0x00056E24 File Offset: 0x00055024
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPropItem.vtkPropItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003BC1 RID: 15297
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropItem_GetPropObject_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The actor to render.
		/// </summary>
		// Token: 0x06003BC2 RID: 15298 RVA: 0x00056E40 File Offset: 0x00055040
		public virtual vtkProp GetPropObject()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropItem.vtkPropItem_GetPropObject_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x06003BC3 RID: 15299
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BC4 RID: 15300 RVA: 0x00056EB0 File Offset: 0x000550B0
		public override int IsA(string type)
		{
			return vtkPropItem.vtkPropItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003BC5 RID: 15301
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BC6 RID: 15302 RVA: 0x00056ED0 File Offset: 0x000550D0
		public new static int IsTypeOf(string type)
		{
			return vtkPropItem.vtkPropItem_IsTypeOf_05(type);
		}

		// Token: 0x06003BC7 RID: 15303
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BC8 RID: 15304 RVA: 0x00056EEC File Offset: 0x000550EC
		public new vtkPropItem NewInstance()
		{
			vtkPropItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropItem.vtkPropItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003BC9 RID: 15305
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPropItem_Paint_08(HandleRef pThis, HandleRef painter);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BCA RID: 15306 RVA: 0x00056F48 File Offset: 0x00055148
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPropItem.vtkPropItem_Paint_08(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06003BCB RID: 15307
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropItem_ReleaseGraphicsResources_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BCC RID: 15308 RVA: 0x00056F83 File Offset: 0x00055183
		public override void ReleaseGraphicsResources()
		{
			vtkPropItem.vtkPropItem_ReleaseGraphicsResources_09(base.GetCppThis());
		}

		// Token: 0x06003BCD RID: 15309
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropItem_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BCE RID: 15310 RVA: 0x00056F94 File Offset: 0x00055194
		public new static vtkPropItem SafeDownCast(vtkObjectBase o)
		{
			vtkPropItem vtkPropItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropItem.vtkPropItem_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropItem = (vtkPropItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropItem.Register(null);
				}
			}
			return vtkPropItem;
		}

		// Token: 0x06003BCF RID: 15311
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropItem_SetPropObject_11(HandleRef pThis, HandleRef PropObject);

		/// <summary>
		/// The actor to render.
		/// </summary>
		// Token: 0x06003BD0 RID: 15312 RVA: 0x00057014 File Offset: 0x00055214
		public virtual void SetPropObject(vtkProp PropObject)
		{
			vtkPropItem.vtkPropItem_SetPropObject_11(base.GetCppThis(), (PropObject == null) ? default(HandleRef) : PropObject.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000681 RID: 1665
		public new const string MRFullTypeName = "Kitware.VTK.vtkPropItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000682 RID: 1666
		public new static readonly string MRClassNameKey = "class vtkPropItem";
	}
}
