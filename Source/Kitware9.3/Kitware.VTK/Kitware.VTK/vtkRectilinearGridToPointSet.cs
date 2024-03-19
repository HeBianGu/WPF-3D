using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridToPointSet
	/// </summary>
	/// <remarks>
	///    Converts a vtkRectilinearGrid to a vtkPointSet
	///
	///
	/// vtkRectilinearGridToPointSet takes a vtkRectilinearGrid as an image and
	/// outputs an equivalent vtkStructuredGrid (which is a subclass of
	/// vtkPointSet).
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// This class was developed by Kenneth Moreland (kmorelndia.gov) from
	/// Sandia National Laboratories.
	/// </seealso>
	// Token: 0x020008D5 RID: 2261
	public class vtkRectilinearGridToPointSet : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017627 RID: 95783 RVA: 0x0020CE14 File Offset: 0x0020B014
		static vtkRectilinearGridToPointSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridToPointSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridToPointSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017628 RID: 95784 RVA: 0x0020CE3C File Offset: 0x0020B03C
		public vtkRectilinearGridToPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017629 RID: 95785
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridToPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601762A RID: 95786 RVA: 0x0020CE4C File Offset: 0x0020B04C
		public new static vtkRectilinearGridToPointSet New()
		{
			vtkRectilinearGridToPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601762B RID: 95787 RVA: 0x0020CEA0 File Offset: 0x0020B0A0
		public vtkRectilinearGridToPointSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601762C RID: 95788 RVA: 0x0020CEE4 File Offset: 0x0020B0E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601762D RID: 95789
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601762E RID: 95790 RVA: 0x0020CEF0 File Offset: 0x0020B0F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601762F RID: 95791
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017630 RID: 95792 RVA: 0x0020CF10 File Offset: 0x0020B110
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017631 RID: 95793
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridToPointSet_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017632 RID: 95794 RVA: 0x0020CF2C File Offset: 0x0020B12C
		public override int IsA(string type)
		{
			return vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017633 RID: 95795
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridToPointSet_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017634 RID: 95796 RVA: 0x0020CF4C File Offset: 0x0020B14C
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_IsTypeOf_04(type);
		}

		// Token: 0x06017635 RID: 95797
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridToPointSet_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017636 RID: 95798 RVA: 0x0020CF68 File Offset: 0x0020B168
		public new vtkRectilinearGridToPointSet NewInstance()
		{
			vtkRectilinearGridToPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017637 RID: 95799
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridToPointSet_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017638 RID: 95800 RVA: 0x0020CFC4 File Offset: 0x0020B1C4
		public new static vtkRectilinearGridToPointSet SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridToPointSet vtkRectilinearGridToPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridToPointSet.vtkRectilinearGridToPointSet_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridToPointSet = (vtkRectilinearGridToPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridToPointSet.Register(null);
				}
			}
			return vtkRectilinearGridToPointSet;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A1D RID: 6685
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridToPointSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A1E RID: 6686
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridToPointSet";
	}
}
