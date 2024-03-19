using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataItem
	/// </summary>
	/// <remarks>
	///    Filter that translate a vtkPolyData 2D mesh into vtkContextItems.
	///
	/// @warning
	/// The input vtkPolyData should be a 2D mesh.
	///
	/// </remarks>
	// Token: 0x020007B3 RID: 1971
	public class vtkPolyDataItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060143EB RID: 82923 RVA: 0x001C9C30 File Offset: 0x001C7E30
		static vtkPolyDataItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060143EC RID: 82924 RVA: 0x001C9C58 File Offset: 0x001C7E58
		public vtkPolyDataItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060143ED RID: 82925
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143EE RID: 82926 RVA: 0x001C9C68 File Offset: 0x001C7E68
		public new static vtkPolyDataItem New()
		{
			vtkPolyDataItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataItem.vtkPolyDataItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143EF RID: 82927 RVA: 0x001C9CBC File Offset: 0x001C7EBC
		public vtkPolyDataItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataItem.vtkPolyDataItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060143F0 RID: 82928 RVA: 0x001C9D00 File Offset: 0x001C7F00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060143F1 RID: 82929
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143F2 RID: 82930 RVA: 0x001C9D0C File Offset: 0x001C7F0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataItem.vtkPolyDataItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060143F3 RID: 82931
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143F4 RID: 82932 RVA: 0x001C9D2C File Offset: 0x001C7F2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataItem.vtkPolyDataItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060143F5 RID: 82933
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataItem_GetPolyData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the image of the item.
		/// </summary>
		// Token: 0x060143F6 RID: 82934 RVA: 0x001C9D48 File Offset: 0x001C7F48
		public virtual vtkPolyData GetPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataItem.vtkPolyDataItem_GetPolyData_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x060143F7 RID: 82935
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143F8 RID: 82936 RVA: 0x001C9DB8 File Offset: 0x001C7FB8
		public override int IsA(string type)
		{
			return vtkPolyDataItem.vtkPolyDataItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060143F9 RID: 82937
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143FA RID: 82938 RVA: 0x001C9DD8 File Offset: 0x001C7FD8
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataItem.vtkPolyDataItem_IsTypeOf_05(type);
		}

		// Token: 0x060143FB RID: 82939
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143FC RID: 82940 RVA: 0x001C9DF4 File Offset: 0x001C7FF4
		public new vtkPolyDataItem NewInstance()
		{
			vtkPolyDataItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataItem.vtkPolyDataItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060143FD RID: 82941
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataItem_Paint_08(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item.
		/// </summary>
		// Token: 0x060143FE RID: 82942 RVA: 0x001C9E50 File Offset: 0x001C8050
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPolyDataItem.vtkPolyDataItem_Paint_08(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060143FF RID: 82943
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014400 RID: 82944 RVA: 0x001C9E8C File Offset: 0x001C808C
		public new static vtkPolyDataItem SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataItem vtkPolyDataItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataItem.vtkPolyDataItem_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataItem = (vtkPolyDataItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataItem.Register(null);
				}
			}
			return vtkPolyDataItem;
		}

		// Token: 0x06014401 RID: 82945
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataItem_SetMappedColors_10(HandleRef pThis, HandleRef colors);

		/// <summary>
		/// Set mapped colors. User-selected scalars are mapped to a color lookup
		/// table externally.
		/// </summary>
		// Token: 0x06014402 RID: 82946 RVA: 0x001C9F0C File Offset: 0x001C810C
		public void SetMappedColors(vtkUnsignedCharArray colors)
		{
			vtkPolyDataItem.vtkPolyDataItem_SetMappedColors_10(base.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis());
		}

		// Token: 0x06014403 RID: 82947
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataItem_SetPolyData_11(HandleRef pThis, HandleRef polyData);

		/// <summary>
		/// Set the PolyData of the item.
		/// </summary>
		// Token: 0x06014404 RID: 82948 RVA: 0x001C9F3C File Offset: 0x001C813C
		public void SetPolyData(vtkPolyData polyData)
		{
			vtkPolyDataItem.vtkPolyDataItem_SetPolyData_11(base.GetCppThis(), (polyData == null) ? default(HandleRef) : polyData.GetCppThis());
		}

		// Token: 0x06014405 RID: 82949
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataItem_SetPosition_12(HandleRef pThis, float _arg1, float _arg2);

		/// <summary>
		/// Set the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x06014406 RID: 82950 RVA: 0x001C9F6B File Offset: 0x001C816B
		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkPolyDataItem.vtkPolyDataItem_SetPosition_12(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06014407 RID: 82951
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataItem_SetPosition_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x06014408 RID: 82952 RVA: 0x001C9F7C File Offset: 0x001C817C
		public void SetPosition(IntPtr _arg)
		{
			vtkPolyDataItem.vtkPolyDataItem_SetPosition_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06014409 RID: 82953
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataItem_SetScalarMode_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the data scalar mode.
		/// </summary>
		// Token: 0x0601440A RID: 82954 RVA: 0x001C9F8C File Offset: 0x001C818C
		public virtual void SetScalarMode(int _arg)
		{
			vtkPolyDataItem.vtkPolyDataItem_SetScalarMode_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001775 RID: 6005
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001776 RID: 6006
		public new static readonly string MRClassNameKey = "class vtkPolyDataItem";
	}
}
