using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSightReader
	/// </summary>
	/// <remarks>
	///    superclass for EnSight file readers
	/// </remarks>
	// Token: 0x020001C1 RID: 449
	public abstract class vtkEnSightReader : vtkGenericEnSightReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005864 RID: 22628 RVA: 0x0007F52B File Offset: 0x0007D72B
		static vtkEnSightReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005865 RID: 22629 RVA: 0x0007F553 File Offset: 0x0007D753
		public vtkEnSightReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005866 RID: 22630 RVA: 0x0007F561 File Offset: 0x0007D761
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005867 RID: 22631
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightReader_GetMatchFileName_01(HandleRef pThis);

		/// <summary>
		/// Get the Match file name. Made public to allow access from
		/// apps requiring detailed info about the Data contents
		/// </summary>
		// Token: 0x06005868 RID: 22632 RVA: 0x0007F56C File Offset: 0x0007D76C
		public virtual string GetMatchFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkEnSightReader.vtkEnSightReader_GetMatchFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005869 RID: 22633
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightReader_GetMeasuredFileName_02(HandleRef pThis);

		/// <summary>
		/// Get the Measured file name. Made public to allow access from
		/// apps requiring detailed info about the Data contents
		/// </summary>
		// Token: 0x0600586A RID: 22634 RVA: 0x0007F5A8 File Offset: 0x0007D7A8
		public virtual string GetMeasuredFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkEnSightReader.vtkEnSightReader_GetMeasuredFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600586B RID: 22635
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600586C RID: 22636 RVA: 0x0007F5E4 File Offset: 0x0007D7E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSightReader.vtkEnSightReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600586D RID: 22637
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600586E RID: 22638 RVA: 0x0007F604 File Offset: 0x0007D804
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSightReader.vtkEnSightReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600586F RID: 22639
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005870 RID: 22640 RVA: 0x0007F620 File Offset: 0x0007D820
		public override int IsA(string type)
		{
			return vtkEnSightReader.vtkEnSightReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06005871 RID: 22641
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005872 RID: 22642 RVA: 0x0007F640 File Offset: 0x0007D840
		public new static int IsTypeOf(string type)
		{
			return vtkEnSightReader.vtkEnSightReader_IsTypeOf_06(type);
		}

		// Token: 0x06005873 RID: 22643
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005874 RID: 22644 RVA: 0x0007F65C File Offset: 0x0007D85C
		public new vtkEnSightReader NewInstance()
		{
			vtkEnSightReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightReader.vtkEnSightReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005875 RID: 22645
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005876 RID: 22646 RVA: 0x0007F6B8 File Offset: 0x0007D8B8
		public new static vtkEnSightReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightReader vtkEnSightReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightReader.vtkEnSightReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightReader = (vtkEnSightReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightReader.Register(null);
				}
			}
			return vtkEnSightReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000829 RID: 2089
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400082A RID: 2090
		public new static readonly string MRClassNameKey = "class vtkEnSightReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020001C2 RID: 450
		public enum ElementTypesList
		{
			/// <summary>enum member</summary>
			// Token: 0x0400082C RID: 2092
			BAR2 = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400082D RID: 2093
			BAR3,
			/// <summary>enum member</summary>
			// Token: 0x0400082E RID: 2094
			HEXA20 = 14,
			/// <summary>enum member</summary>
			// Token: 0x0400082F RID: 2095
			HEXA8 = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000830 RID: 2096
			NFACED = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000831 RID: 2097
			NSIDED = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000832 RID: 2098
			NUMBER_OF_ELEMENT_TYPES = 17,
			/// <summary>enum member</summary>
			// Token: 0x04000833 RID: 2099
			PENTA15 = 16,
			/// <summary>enum member</summary>
			// Token: 0x04000834 RID: 2100
			PENTA6 = 15,
			/// <summary>enum member</summary>
			// Token: 0x04000835 RID: 2101
			POINT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000836 RID: 2102
			PYRAMID13 = 12,
			/// <summary>enum member</summary>
			// Token: 0x04000837 RID: 2103
			PYRAMID5 = 11,
			/// <summary>enum member</summary>
			// Token: 0x04000838 RID: 2104
			QUAD4 = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000839 RID: 2105
			QUAD8,
			/// <summary>enum member</summary>
			// Token: 0x0400083A RID: 2106
			TETRA10 = 10,
			/// <summary>enum member</summary>
			// Token: 0x0400083B RID: 2107
			TETRA4 = 9,
			/// <summary>enum member</summary>
			// Token: 0x0400083C RID: 2108
			TRIA3 = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400083D RID: 2109
			TRIA6
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020001C3 RID: 451
		public enum SectionTypeList
		{
			/// <summary>enum member</summary>
			// Token: 0x0400083F RID: 2111
			BLOCK = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000840 RID: 2112
			COORDINATES = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000841 RID: 2113
			ELEMENT = 2
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020001C4 RID: 452
		public enum VariableTypesList
		{
			/// <summary>enum member</summary>
			// Token: 0x04000843 RID: 2115
			COMPLEX_SCALAR_PER_ELEMENT = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000844 RID: 2116
			COMPLEX_SCALAR_PER_NODE = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000845 RID: 2117
			COMPLEX_VECTOR_PER_ELEMENT = 11,
			/// <summary>enum member</summary>
			// Token: 0x04000846 RID: 2118
			COMPLEX_VECTOR_PER_NODE = 9,
			/// <summary>enum member</summary>
			// Token: 0x04000847 RID: 2119
			SCALAR_PER_ELEMENT = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000848 RID: 2120
			SCALAR_PER_MEASURED_NODE = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000849 RID: 2121
			SCALAR_PER_NODE = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400084A RID: 2122
			TENSOR_ASYM_PER_ELEMENT = 13,
			/// <summary>enum member</summary>
			// Token: 0x0400084B RID: 2123
			TENSOR_ASYM_PER_NODE = 12,
			/// <summary>enum member</summary>
			// Token: 0x0400084C RID: 2124
			TENSOR_SYMM_PER_ELEMENT = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400084D RID: 2125
			TENSOR_SYMM_PER_NODE = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400084E RID: 2126
			VECTOR_PER_ELEMENT = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400084F RID: 2127
			VECTOR_PER_MEASURED_NODE = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000850 RID: 2128
			VECTOR_PER_NODE = 1
		}
	}
}
