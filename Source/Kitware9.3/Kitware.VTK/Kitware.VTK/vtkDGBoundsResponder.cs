using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGBoundsResponder
	/// </summary>
	/// <remarks>
	///    Respond to a query on one particular type of cell.
	///
	/// This is pure virtual base class that all responder types must inherit.
	/// </remarks>
	// Token: 0x020004D1 RID: 1233
	public class vtkDGBoundsResponder : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E084 RID: 57476 RVA: 0x001377BB File Offset: 0x001359BB
		static vtkDGBoundsResponder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGBoundsResponder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGBoundsResponder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E085 RID: 57477 RVA: 0x001377E3 File Offset: 0x001359E3
		public vtkDGBoundsResponder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E086 RID: 57478
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGBoundsResponder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E087 RID: 57479 RVA: 0x001377F4 File Offset: 0x001359F4
		public new static vtkDGBoundsResponder New()
		{
			vtkDGBoundsResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGBoundsResponder.vtkDGBoundsResponder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGBoundsResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E088 RID: 57480 RVA: 0x00137848 File Offset: 0x00135A48
		public vtkDGBoundsResponder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGBoundsResponder.vtkDGBoundsResponder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E089 RID: 57481 RVA: 0x0013788C File Offset: 0x00135A8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E08A RID: 57482
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGBoundsResponder_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E08B RID: 57483 RVA: 0x00137898 File Offset: 0x00135A98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGBoundsResponder.vtkDGBoundsResponder_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E08C RID: 57484
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGBoundsResponder_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E08D RID: 57485 RVA: 0x001378B8 File Offset: 0x00135AB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGBoundsResponder.vtkDGBoundsResponder_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E08E RID: 57486
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGBoundsResponder_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E08F RID: 57487 RVA: 0x001378D4 File Offset: 0x00135AD4
		public override int IsA(string type)
		{
			return vtkDGBoundsResponder.vtkDGBoundsResponder_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E090 RID: 57488
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGBoundsResponder_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E091 RID: 57489 RVA: 0x001378F4 File Offset: 0x00135AF4
		public new static int IsTypeOf(string type)
		{
			return vtkDGBoundsResponder.vtkDGBoundsResponder_IsTypeOf_04(type);
		}

		// Token: 0x0600E092 RID: 57490
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGBoundsResponder_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E093 RID: 57491 RVA: 0x00137910 File Offset: 0x00135B10
		public new vtkDGBoundsResponder NewInstance()
		{
			vtkDGBoundsResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGBoundsResponder.vtkDGBoundsResponder_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGBoundsResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E094 RID: 57492
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGBoundsResponder_Query_07(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E095 RID: 57493 RVA: 0x0013796C File Offset: 0x00135B6C
		public virtual bool Query(vtkCellGridBoundsQuery query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkDGBoundsResponder.vtkDGBoundsResponder_Query_07(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x0600E096 RID: 57494
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGBoundsResponder_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E097 RID: 57495 RVA: 0x001379D4 File Offset: 0x00135BD4
		public new static vtkDGBoundsResponder SafeDownCast(vtkObjectBase o)
		{
			vtkDGBoundsResponder vtkDGBoundsResponder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGBoundsResponder.vtkDGBoundsResponder_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGBoundsResponder = (vtkDGBoundsResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGBoundsResponder.Register(null);
				}
			}
			return vtkDGBoundsResponder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400107D RID: 4221
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGBoundsResponder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400107E RID: 4222
		public new static readonly string MRClassNameKey = "class vtkDGBoundsResponder";
	}
}
