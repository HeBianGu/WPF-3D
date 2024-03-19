using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeReader
	/// </summary>
	/// <remarks>
	///    read vtkTree data file
	///
	/// vtkTreeReader is a source object that reads ASCII or binary
	/// vtkTree data files in vtk format. (see text for format details).
	/// The output of this reader is a single vtkTree data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTree vtkDataReader vtkTreeWriter
	/// </seealso>
	// Token: 0x02000717 RID: 1815
	public class vtkTreeReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601304E RID: 77902 RVA: 0x001ADC17 File Offset: 0x001ABE17
		static vtkTreeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601304F RID: 77903 RVA: 0x001ADC3F File Offset: 0x001ABE3F
		public vtkTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013050 RID: 77904
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013051 RID: 77905 RVA: 0x001ADC50 File Offset: 0x001ABE50
		public new static vtkTreeReader New()
		{
			vtkTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeReader.vtkTreeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013052 RID: 77906 RVA: 0x001ADCA4 File Offset: 0x001ABEA4
		public vtkTreeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeReader.vtkTreeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013053 RID: 77907 RVA: 0x001ADCE8 File Offset: 0x001ABEE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013054 RID: 77908
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013055 RID: 77909 RVA: 0x001ADCF4 File Offset: 0x001ABEF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeReader.vtkTreeReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013056 RID: 77910
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013057 RID: 77911 RVA: 0x001ADD14 File Offset: 0x001ABF14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeReader.vtkTreeReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013058 RID: 77912
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06013059 RID: 77913 RVA: 0x001ADD30 File Offset: 0x001ABF30
		public vtkTree GetOutput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeReader.vtkTreeReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0601305A RID: 77914
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x0601305B RID: 77915 RVA: 0x001ADDA0 File Offset: 0x001ABFA0
		public vtkTree GetOutput(int idx)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeReader.vtkTreeReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0601305C RID: 77916
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601305D RID: 77917 RVA: 0x001ADE10 File Offset: 0x001AC010
		public override int IsA(string type)
		{
			return vtkTreeReader.vtkTreeReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601305E RID: 77918
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601305F RID: 77919 RVA: 0x001ADE30 File Offset: 0x001AC030
		public new static int IsTypeOf(string type)
		{
			return vtkTreeReader.vtkTreeReader_IsTypeOf_06(type);
		}

		// Token: 0x06013060 RID: 77920
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013061 RID: 77921 RVA: 0x001ADE4C File Offset: 0x001AC04C
		public new vtkTreeReader NewInstance()
		{
			vtkTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeReader.vtkTreeReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013062 RID: 77922
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06013063 RID: 77923 RVA: 0x001ADEA8 File Offset: 0x001AC0A8
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkTreeReader.vtkTreeReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06013064 RID: 77924
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013065 RID: 77925 RVA: 0x001ADEE0 File Offset: 0x001AC0E0
		public new static vtkTreeReader SafeDownCast(vtkObjectBase o)
		{
			vtkTreeReader vtkTreeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeReader.vtkTreeReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeReader = (vtkTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeReader.Register(null);
				}
			}
			return vtkTreeReader;
		}

		// Token: 0x06013066 RID: 77926
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06013067 RID: 77927 RVA: 0x001ADF60 File Offset: 0x001AC160
		public void SetOutput(vtkTree output)
		{
			vtkTreeReader.vtkTreeReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015FA RID: 5626
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015FB RID: 5627
		public new static readonly string MRClassNameKey = "class vtkTreeReader";
	}
}
