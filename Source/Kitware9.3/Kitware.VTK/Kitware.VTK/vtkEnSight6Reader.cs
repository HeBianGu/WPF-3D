using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSight6Reader
	/// </summary>
	/// <remarks>
	///    class to read EnSight6 files
	///
	/// vtkEnSight6Reader is a class to read EnSight6 files into vtk.
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
	// Token: 0x020001C6 RID: 454
	public class vtkEnSight6Reader : vtkEnSightReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005889 RID: 22665 RVA: 0x0007F967 File Offset: 0x0007DB67
		static vtkEnSight6Reader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSight6Reader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSight6Reader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600588A RID: 22666 RVA: 0x0007F98F File Offset: 0x0007DB8F
		public vtkEnSight6Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600588B RID: 22667
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSight6Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600588C RID: 22668 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
		public new static vtkEnSight6Reader New()
		{
			vtkEnSight6Reader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSight6Reader.vtkEnSight6Reader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600588D RID: 22669 RVA: 0x0007F9F4 File Offset: 0x0007DBF4
		public vtkEnSight6Reader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnSight6Reader.vtkEnSight6Reader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600588E RID: 22670 RVA: 0x0007FA38 File Offset: 0x0007DC38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600588F RID: 22671
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSight6Reader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005890 RID: 22672 RVA: 0x0007FA44 File Offset: 0x0007DC44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSight6Reader.vtkEnSight6Reader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005891 RID: 22673
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSight6Reader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005892 RID: 22674 RVA: 0x0007FA64 File Offset: 0x0007DC64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSight6Reader.vtkEnSight6Reader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005893 RID: 22675
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSight6Reader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005894 RID: 22676 RVA: 0x0007FA80 File Offset: 0x0007DC80
		public override int IsA(string type)
		{
			return vtkEnSight6Reader.vtkEnSight6Reader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06005895 RID: 22677
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSight6Reader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005896 RID: 22678 RVA: 0x0007FAA0 File Offset: 0x0007DCA0
		public new static int IsTypeOf(string type)
		{
			return vtkEnSight6Reader.vtkEnSight6Reader_IsTypeOf_04(type);
		}

		// Token: 0x06005897 RID: 22679
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSight6Reader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005898 RID: 22680 RVA: 0x0007FABC File Offset: 0x0007DCBC
		public new vtkEnSight6Reader NewInstance()
		{
			vtkEnSight6Reader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSight6Reader.vtkEnSight6Reader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005899 RID: 22681
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSight6Reader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600589A RID: 22682 RVA: 0x0007FB18 File Offset: 0x0007DD18
		public new static vtkEnSight6Reader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSight6Reader vtkEnSight6Reader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSight6Reader.vtkEnSight6Reader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSight6Reader = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSight6Reader.Register(null);
				}
			}
			return vtkEnSight6Reader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000853 RID: 2131
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSight6Reader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000854 RID: 2132
		public new static readonly string MRClassNameKey = "class vtkEnSight6Reader";
	}
}
