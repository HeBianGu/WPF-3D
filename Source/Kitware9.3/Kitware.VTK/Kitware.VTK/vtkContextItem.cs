using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextItem
	/// </summary>
	/// <remarks>
	///    base class for items that are part of a vtkContextScene.
	///
	///
	/// Derive from this class to create custom items that can be added to a
	/// vtkContextScene.
	/// </remarks>
	// Token: 0x02000061 RID: 97
	public class vtkContextItem : vtkAbstractContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600119B RID: 4507 RVA: 0x0001F734 File Offset: 0x0001D934
		static vtkContextItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600119C RID: 4508 RVA: 0x0001F75C File Offset: 0x0001D95C
		public vtkContextItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600119D RID: 4509 RVA: 0x0001F76A File Offset: 0x0001D96A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600119E RID: 4510
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600119F RID: 4511 RVA: 0x0001F778 File Offset: 0x0001D978
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextItem.vtkContextItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060011A0 RID: 4512
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011A1 RID: 4513 RVA: 0x0001F798 File Offset: 0x0001D998
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextItem.vtkContextItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060011A2 RID: 4514
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContextItem_GetOpacity_03(HandleRef pThis);

		/// <summary>
		/// Get the opacity of the item.
		/// </summary>
		// Token: 0x060011A3 RID: 4515 RVA: 0x0001F7B4 File Offset: 0x0001D9B4
		public virtual double GetOpacity()
		{
			return vtkContextItem.vtkContextItem_GetOpacity_03(base.GetCppThis());
		}

		// Token: 0x060011A4 RID: 4516
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011A5 RID: 4517 RVA: 0x0001F7D4 File Offset: 0x0001D9D4
		public override int IsA(string type)
		{
			return vtkContextItem.vtkContextItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060011A6 RID: 4518
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011A7 RID: 4519 RVA: 0x0001F7F4 File Offset: 0x0001D9F4
		public new static int IsTypeOf(string type)
		{
			return vtkContextItem.vtkContextItem_IsTypeOf_05(type);
		}

		// Token: 0x060011A8 RID: 4520
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011A9 RID: 4521 RVA: 0x0001F810 File Offset: 0x0001DA10
		public new vtkContextItem NewInstance()
		{
			vtkContextItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextItem.vtkContextItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060011AA RID: 4522
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextItem_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011AB RID: 4523 RVA: 0x0001F86C File Offset: 0x0001DA6C
		public new static vtkContextItem SafeDownCast(vtkObjectBase o)
		{
			vtkContextItem vtkContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextItem.vtkContextItem_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextItem = (vtkContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextItem.Register(null);
				}
			}
			return vtkContextItem;
		}

		// Token: 0x060011AC RID: 4524
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextItem_SetOpacity_08(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the opacity of the item.
		/// 1.0 by default.
		/// </summary>
		// Token: 0x060011AD RID: 4525 RVA: 0x0001F8EB File Offset: 0x0001DAEB
		public virtual void SetOpacity(double _arg)
		{
			vtkContextItem.vtkContextItem_SetOpacity_08(base.GetCppThis(), _arg);
		}

		// Token: 0x060011AE RID: 4526
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextItem_SetTransform_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the transform of the item.
		/// </summary>
		// Token: 0x060011AF RID: 4527 RVA: 0x0001F8FC File Offset: 0x0001DAFC
		public virtual void SetTransform(vtkContextTransform arg0)
		{
			vtkContextItem.vtkContextItem_SetTransform_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000445 RID: 1093
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000446 RID: 1094
		public new static readonly string MRClassNameKey = "class vtkContextItem";
	}
}
