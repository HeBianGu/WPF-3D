using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSightGoldBinaryReader
	/// </summary>
	/// <remarks>
	///    class to read binary EnSight Gold files
	///
	/// vtkEnSightGoldBinaryReader is a class to read EnSight Gold files into vtk.
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
	// Token: 0x020001C7 RID: 455
	public class vtkEnSightGoldBinaryReader : vtkEnSightReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600589B RID: 22683 RVA: 0x0007FB97 File Offset: 0x0007DD97
		static vtkEnSightGoldBinaryReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightGoldBinaryReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightGoldBinaryReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600589C RID: 22684 RVA: 0x0007FBBF File Offset: 0x0007DDBF
		public vtkEnSightGoldBinaryReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600589D RID: 22685
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightGoldBinaryReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600589E RID: 22686 RVA: 0x0007FBD0 File Offset: 0x0007DDD0
		public new static vtkEnSightGoldBinaryReader New()
		{
			vtkEnSightGoldBinaryReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldBinaryReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600589F RID: 22687 RVA: 0x0007FC24 File Offset: 0x0007DE24
		public vtkEnSightGoldBinaryReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060058A0 RID: 22688 RVA: 0x0007FC68 File Offset: 0x0007DE68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060058A1 RID: 22689
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightGoldBinaryReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058A2 RID: 22690 RVA: 0x0007FC74 File Offset: 0x0007DE74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060058A3 RID: 22691
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightGoldBinaryReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058A4 RID: 22692 RVA: 0x0007FC94 File Offset: 0x0007DE94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060058A5 RID: 22693
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightGoldBinaryReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058A6 RID: 22694 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
		public override int IsA(string type)
		{
			return vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060058A7 RID: 22695
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightGoldBinaryReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058A8 RID: 22696 RVA: 0x0007FCD0 File Offset: 0x0007DED0
		public new static int IsTypeOf(string type)
		{
			return vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_IsTypeOf_04(type);
		}

		// Token: 0x060058A9 RID: 22697
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightGoldBinaryReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058AA RID: 22698 RVA: 0x0007FCEC File Offset: 0x0007DEEC
		public new vtkEnSightGoldBinaryReader NewInstance()
		{
			vtkEnSightGoldBinaryReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldBinaryReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060058AB RID: 22699
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightGoldBinaryReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058AC RID: 22700 RVA: 0x0007FD48 File Offset: 0x0007DF48
		public new static vtkEnSightGoldBinaryReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightGoldBinaryReader vtkEnSightGoldBinaryReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightGoldBinaryReader = (vtkEnSightGoldBinaryReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightGoldBinaryReader.Register(null);
				}
			}
			return vtkEnSightGoldBinaryReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000855 RID: 2133
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightGoldBinaryReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000856 RID: 2134
		public new static readonly string MRClassNameKey = "class vtkEnSightGoldBinaryReader";
	}
}
