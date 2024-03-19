using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSight6BinaryReader
	/// </summary>
	/// <remarks>
	///    class to read binary EnSight6 files
	///
	/// vtkEnSight6BinaryReader is a class to read binary EnSight6 files into vtk.
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
	/// </remarks>
	// Token: 0x020001C5 RID: 453
	public class vtkEnSight6BinaryReader : vtkEnSightReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005877 RID: 22647 RVA: 0x0007F737 File Offset: 0x0007D937
		static vtkEnSight6BinaryReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSight6BinaryReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSight6BinaryReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005878 RID: 22648 RVA: 0x0007F75F File Offset: 0x0007D95F
		public vtkEnSight6BinaryReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005879 RID: 22649
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSight6BinaryReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600587A RID: 22650 RVA: 0x0007F770 File Offset: 0x0007D970
		public new static vtkEnSight6BinaryReader New()
		{
			vtkEnSight6BinaryReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6BinaryReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600587B RID: 22651 RVA: 0x0007F7C4 File Offset: 0x0007D9C4
		public vtkEnSight6BinaryReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600587C RID: 22652 RVA: 0x0007F808 File Offset: 0x0007DA08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600587D RID: 22653
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSight6BinaryReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600587E RID: 22654 RVA: 0x0007F814 File Offset: 0x0007DA14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600587F RID: 22655
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSight6BinaryReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005880 RID: 22656 RVA: 0x0007F834 File Offset: 0x0007DA34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005881 RID: 22657
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSight6BinaryReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005882 RID: 22658 RVA: 0x0007F850 File Offset: 0x0007DA50
		public override int IsA(string type)
		{
			return vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06005883 RID: 22659
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSight6BinaryReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005884 RID: 22660 RVA: 0x0007F870 File Offset: 0x0007DA70
		public new static int IsTypeOf(string type)
		{
			return vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_IsTypeOf_04(type);
		}

		// Token: 0x06005885 RID: 22661
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSight6BinaryReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005886 RID: 22662 RVA: 0x0007F88C File Offset: 0x0007DA8C
		public new vtkEnSight6BinaryReader NewInstance()
		{
			vtkEnSight6BinaryReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6BinaryReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005887 RID: 22663
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSight6BinaryReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005888 RID: 22664 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
		public new static vtkEnSight6BinaryReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSight6BinaryReader vtkEnSight6BinaryReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSight6BinaryReader = (vtkEnSight6BinaryReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSight6BinaryReader.Register(null);
				}
			}
			return vtkEnSight6BinaryReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000851 RID: 2129
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSight6BinaryReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000852 RID: 2130
		public new static readonly string MRClassNameKey = "class vtkEnSight6BinaryReader";
	}
}
