using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtk3DSImporter
	/// </summary>
	/// <remarks>
	///    imports 3D Studio files.
	///
	/// vtk3DSImporter imports 3D Studio files into vtk.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImporter
	/// </seealso>
	// Token: 0x02000185 RID: 389
	public class vtk3DSImporter : vtkImporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004ACD RID: 19149 RVA: 0x0006CE5A File Offset: 0x0006B05A
		static vtk3DSImporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DSImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DSImporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004ACE RID: 19150 RVA: 0x0006CE82 File Offset: 0x0006B082
		public vtk3DSImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004ACF RID: 19151
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DSImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AD0 RID: 19152 RVA: 0x0006CE90 File Offset: 0x0006B090
		public new static vtk3DSImporter New()
		{
			vtk3DSImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DSImporter.vtk3DSImporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AD1 RID: 19153 RVA: 0x0006CEE4 File Offset: 0x0006B0E4
		public vtk3DSImporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtk3DSImporter.vtk3DSImporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004AD2 RID: 19154 RVA: 0x0006CF28 File Offset: 0x0006B128
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004AD3 RID: 19155
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DSImporter_ComputeNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. If on, imported geometry will
		/// be run through vtkPolyDataNormals.
		/// </summary>
		// Token: 0x06004AD4 RID: 19156 RVA: 0x0006CF33 File Offset: 0x0006B133
		public virtual void ComputeNormalsOff()
		{
			vtk3DSImporter.vtk3DSImporter_ComputeNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x06004AD5 RID: 19157
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DSImporter_ComputeNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. If on, imported geometry will
		/// be run through vtkPolyDataNormals.
		/// </summary>
		// Token: 0x06004AD6 RID: 19158 RVA: 0x0006CF42 File Offset: 0x0006B142
		public virtual void ComputeNormalsOn()
		{
			vtk3DSImporter.vtk3DSImporter_ComputeNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x06004AD7 RID: 19159
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DSImporter_GetComputeNormals_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. If on, imported geometry will
		/// be run through vtkPolyDataNormals.
		/// </summary>
		// Token: 0x06004AD8 RID: 19160 RVA: 0x0006CF54 File Offset: 0x0006B154
		public virtual int GetComputeNormals()
		{
			return vtk3DSImporter.vtk3DSImporter_GetComputeNormals_03(base.GetCppThis());
		}

		// Token: 0x06004AD9 RID: 19161
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DSImporter_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004ADA RID: 19162 RVA: 0x0006CF74 File Offset: 0x0006B174
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtk3DSImporter.vtk3DSImporter_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004ADB RID: 19163
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DSImporter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004ADC RID: 19164 RVA: 0x0006CFB0 File Offset: 0x0006B1B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtk3DSImporter.vtk3DSImporter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06004ADD RID: 19165
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DSImporter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004ADE RID: 19166 RVA: 0x0006CFD0 File Offset: 0x0006B1D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtk3DSImporter.vtk3DSImporter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06004ADF RID: 19167
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtk3DSImporter_GetOutputsDescription_07(HandleRef pThis);

		/// <summary>
		/// Get a printable string describing the outputs
		/// </summary>
		// Token: 0x06004AE0 RID: 19168 RVA: 0x0006CFEC File Offset: 0x0006B1EC
		public override string GetOutputsDescription()
		{
			return vtk3DSImporter.vtk3DSImporter_GetOutputsDescription_07(base.GetCppThis());
		}

		// Token: 0x06004AE1 RID: 19169
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DSImporter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AE2 RID: 19170 RVA: 0x0006D00C File Offset: 0x0006B20C
		public override int IsA(string type)
		{
			return vtk3DSImporter.vtk3DSImporter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06004AE3 RID: 19171
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DSImporter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AE4 RID: 19172 RVA: 0x0006D02C File Offset: 0x0006B22C
		public new static int IsTypeOf(string type)
		{
			return vtk3DSImporter.vtk3DSImporter_IsTypeOf_09(type);
		}

		// Token: 0x06004AE5 RID: 19173
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DSImporter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AE6 RID: 19174 RVA: 0x0006D048 File Offset: 0x0006B248
		public new vtk3DSImporter NewInstance()
		{
			vtk3DSImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DSImporter.vtk3DSImporter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004AE7 RID: 19175
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DSImporter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AE8 RID: 19176 RVA: 0x0006D0A4 File Offset: 0x0006B2A4
		public new static vtk3DSImporter SafeDownCast(vtkObjectBase o)
		{
			vtk3DSImporter vtk3DSImporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DSImporter.vtk3DSImporter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DSImporter = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DSImporter.Register(null);
				}
			}
			return vtk3DSImporter;
		}

		// Token: 0x06004AE9 RID: 19177
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DSImporter_SetComputeNormals_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. If on, imported geometry will
		/// be run through vtkPolyDataNormals.
		/// </summary>
		// Token: 0x06004AEA RID: 19178 RVA: 0x0006D123 File Offset: 0x0006B323
		public virtual void SetComputeNormals(int _arg)
		{
			vtk3DSImporter.vtk3DSImporter_SetComputeNormals_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06004AEB RID: 19179
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DSImporter_SetFileName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004AEC RID: 19180 RVA: 0x0006D133 File Offset: 0x0006B333
		public virtual void SetFileName(string _arg)
		{
			vtk3DSImporter.vtk3DSImporter_SetFileName_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400075B RID: 1883
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DSImporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400075C RID: 1884
		public new static readonly string MRClassNameKey = "class vtk3DSImporter";
	}
}
