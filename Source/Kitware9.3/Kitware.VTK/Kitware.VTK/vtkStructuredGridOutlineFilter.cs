using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridOutlineFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline for structured grid
	///
	/// vtkStructuredGridOutlineFilter is a filter that generates a wireframe
	/// outline of a structured grid (vtkStructuredGrid). Structured data is
	/// topologically a cube, so the outline will have 12 "edges".
	/// </remarks>
	// Token: 0x020009A9 RID: 2473
	public class vtkStructuredGridOutlineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019D1F RID: 105759 RVA: 0x0023DB73 File Offset: 0x0023BD73
		static vtkStructuredGridOutlineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridOutlineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019D20 RID: 105760 RVA: 0x0023DB9B File Offset: 0x0023BD9B
		public vtkStructuredGridOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019D21 RID: 105761
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D22 RID: 105762 RVA: 0x0023DBAC File Offset: 0x0023BDAC
		public new static vtkStructuredGridOutlineFilter New()
		{
			vtkStructuredGridOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D23 RID: 105763 RVA: 0x0023DC00 File Offset: 0x0023BE00
		public vtkStructuredGridOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019D24 RID: 105764 RVA: 0x0023DC44 File Offset: 0x0023BE44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019D25 RID: 105765
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridOutlineFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D26 RID: 105766 RVA: 0x0023DC50 File Offset: 0x0023BE50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06019D27 RID: 105767
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridOutlineFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D28 RID: 105768 RVA: 0x0023DC70 File Offset: 0x0023BE70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06019D29 RID: 105769
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridOutlineFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D2A RID: 105770 RVA: 0x0023DC8C File Offset: 0x0023BE8C
		public override int IsA(string type)
		{
			return vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06019D2B RID: 105771
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridOutlineFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D2C RID: 105772 RVA: 0x0023DCAC File Offset: 0x0023BEAC
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_IsTypeOf_04(type);
		}

		// Token: 0x06019D2D RID: 105773
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridOutlineFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D2E RID: 105774 RVA: 0x0023DCC8 File Offset: 0x0023BEC8
		public new vtkStructuredGridOutlineFilter NewInstance()
		{
			vtkStructuredGridOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019D2F RID: 105775
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridOutlineFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D30 RID: 105776 RVA: 0x0023DD24 File Offset: 0x0023BF24
		public new static vtkStructuredGridOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridOutlineFilter vtkStructuredGridOutlineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridOutlineFilter = (vtkStructuredGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridOutlineFilter.Register(null);
				}
			}
			return vtkStructuredGridOutlineFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C0F RID: 7183
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridOutlineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C10 RID: 7184
		public new static readonly string MRClassNameKey = "class vtkStructuredGridOutlineFilter";
	}
}
