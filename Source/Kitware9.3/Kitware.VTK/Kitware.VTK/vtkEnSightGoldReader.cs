using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSightGoldReader
	/// </summary>
	/// <remarks>
	///    class to read EnSight Gold files
	///
	/// vtkEnSightGoldReader is a class to read EnSight Gold files into vtk.
	/// Because the different parts of the EnSight data can be of various data
	/// types, this reader produces multiple outputs, one per part in the input
	/// file.
	/// All variable information is being stored in field data.  The descriptions
	/// listed in the case file are used as the array names in the field data.
	/// For complex vector variables, the description is appended with _r (for the
	/// array of real values) and _i (for the array if imaginary values).  Complex
	/// scalar variables are stored as a single array with 2 components, real and
	/// imaginary, listed in that order.
	/// @warning
	/// You must manually call Update on this reader and then connect the rest
	/// of the pipeline because (due to the nature of the file format) it is
	/// not possible to know ahead of time how many outputs you will have or
	/// what types they will be.
	/// This reader can only handle static EnSight datasets (both static geometry
	/// and variables).
	/// @par Thanks:
	/// Thanks to Yvan Fournier for providing the code to support nfaced elements.
	/// </remarks>
	// Token: 0x020001C8 RID: 456
	public class vtkEnSightGoldReader : vtkEnSightReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060058AD RID: 22701 RVA: 0x0007FDC7 File Offset: 0x0007DFC7
		static vtkEnSightGoldReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightGoldReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightGoldReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060058AE RID: 22702 RVA: 0x0007FDEF File Offset: 0x0007DFEF
		public vtkEnSightGoldReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060058AF RID: 22703
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightGoldReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058B0 RID: 22704 RVA: 0x0007FE00 File Offset: 0x0007E000
		public new static vtkEnSightGoldReader New()
		{
			vtkEnSightGoldReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightGoldReader.vtkEnSightGoldReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058B1 RID: 22705 RVA: 0x0007FE54 File Offset: 0x0007E054
		public vtkEnSightGoldReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnSightGoldReader.vtkEnSightGoldReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060058B2 RID: 22706 RVA: 0x0007FE98 File Offset: 0x0007E098
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060058B3 RID: 22707
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightGoldReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058B4 RID: 22708 RVA: 0x0007FEA4 File Offset: 0x0007E0A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSightGoldReader.vtkEnSightGoldReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060058B5 RID: 22709
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightGoldReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058B6 RID: 22710 RVA: 0x0007FEC4 File Offset: 0x0007E0C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSightGoldReader.vtkEnSightGoldReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060058B7 RID: 22711
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightGoldReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058B8 RID: 22712 RVA: 0x0007FEE0 File Offset: 0x0007E0E0
		public override int IsA(string type)
		{
			return vtkEnSightGoldReader.vtkEnSightGoldReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060058B9 RID: 22713
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightGoldReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058BA RID: 22714 RVA: 0x0007FF00 File Offset: 0x0007E100
		public new static int IsTypeOf(string type)
		{
			return vtkEnSightGoldReader.vtkEnSightGoldReader_IsTypeOf_04(type);
		}

		// Token: 0x060058BB RID: 22715
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightGoldReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058BC RID: 22716 RVA: 0x0007FF1C File Offset: 0x0007E11C
		public new vtkEnSightGoldReader NewInstance()
		{
			vtkEnSightGoldReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightGoldReader.vtkEnSightGoldReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060058BD RID: 22717
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightGoldReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058BE RID: 22718 RVA: 0x0007FF78 File Offset: 0x0007E178
		public new static vtkEnSightGoldReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightGoldReader vtkEnSightGoldReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightGoldReader.vtkEnSightGoldReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightGoldReader = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightGoldReader.Register(null);
				}
			}
			return vtkEnSightGoldReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000857 RID: 2135
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightGoldReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000858 RID: 2136
		public new static readonly string MRClassNameKey = "class vtkEnSightGoldReader";
	}
}
