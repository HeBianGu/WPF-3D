using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkFDSReader
	///
	/// A reader for the Fire Dynamics Simulator (FDS) output data.
	///
	/// This class reads in the `.smv` file and uses the meta-data to identify the other
	/// files to read automatically. It outputs a `vtkPartitionedDataSetCollection`
	/// containing 5 groups: Grids, Devices, HRR, Slices and Boundaries. Each group
	/// contains data sets with the expected values for users of the FDS code.
	/// </summary>
	// Token: 0x02000190 RID: 400
	public class vtkFDSReader : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004E26 RID: 20006 RVA: 0x00071953 File Offset: 0x0006FB53
		static vtkFDSReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFDSReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFDSReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004E27 RID: 20007 RVA: 0x0007197B File Offset: 0x0006FB7B
		public vtkFDSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004E28 RID: 20008
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFDSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E29 RID: 20009 RVA: 0x0007198C File Offset: 0x0006FB8C
		public new static vtkFDSReader New()
		{
			vtkFDSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFDSReader.vtkFDSReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFDSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E2A RID: 20010 RVA: 0x000719E0 File Offset: 0x0006FBE0
		public vtkFDSReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFDSReader.vtkFDSReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004E2B RID: 20011 RVA: 0x00071A24 File Offset: 0x0006FC24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004E2C RID: 20012
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFDSReader_AddSelector_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// API to set selectors. Multiple selectors can be added using `AddSelector`.
		/// The order in which selectors are specified is not preserved and has no
		/// impact on the result.
		///
		/// `AddSelector` returns true if the selector was added, false if the selector
		/// was already specified and hence not added.
		///
		/// @sa vtkDataAssembly::SelectNodes
		/// </summary>
		// Token: 0x06004E2D RID: 20013 RVA: 0x00071A30 File Offset: 0x0006FC30
		public bool AddSelector(string selector)
		{
			return vtkFDSReader.vtkFDSReader_AddSelector_01(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004E2E RID: 20014
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFDSReader_ClearSelectors_02(HandleRef pThis);

		/// <summary>
		/// API to set selectors. Multiple selectors can be added using `AddSelector`.
		/// The order in which selectors are specified is not preserved and has no
		/// impact on the result.
		///
		/// `AddSelector` returns true if the selector was added, false if the selector
		/// was already specified and hence not added.
		///
		/// @sa vtkDataAssembly::SelectNodes
		/// </summary>
		// Token: 0x06004E2F RID: 20015 RVA: 0x00071A57 File Offset: 0x0006FC57
		public void ClearSelectors()
		{
			vtkFDSReader.vtkFDSReader_ClearSelectors_02(base.GetCppThis());
		}

		// Token: 0x06004E30 RID: 20016
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFDSReader_GetAssembly_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data full data assembly associated with the input
		/// </summary>
		// Token: 0x06004E31 RID: 20017 RVA: 0x00071A68 File Offset: 0x0006FC68
		public virtual vtkDataAssembly GetAssembly()
		{
			vtkDataAssembly vtkDataAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFDSReader.vtkFDSReader_GetAssembly_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataAssembly = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataAssembly.Register(null);
				}
			}
			return vtkDataAssembly;
		}

		// Token: 0x06004E32 RID: 20018
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFDSReader_GetAssemblyTag_04(HandleRef pThis);

		/// <summary>
		/// Whenever the assembly is changed, this tag gets changed. Note, users should
		/// not assume that this is monotonically increasing but instead simply rely on
		/// its value to determine if the assembly may have changed since last time.
		///
		/// It is set to 0 whenever there's no valid assembly available.
		/// </summary>
		// Token: 0x06004E33 RID: 20019 RVA: 0x00071AD8 File Offset: 0x0006FCD8
		public virtual int GetAssemblyTag()
		{
			return vtkFDSReader.vtkFDSReader_GetAssemblyTag_04(base.GetCppThis());
		}

		// Token: 0x06004E34 RID: 20020
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkFDSReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Specifies the name of the .smv file to be loaded.
		/// </summary>
		// Token: 0x06004E35 RID: 20021 RVA: 0x00071AF8 File Offset: 0x0006FCF8
		public virtual string GetFileName()
		{
			return vtkFDSReader.vtkFDSReader_GetFileName_05(base.GetCppThis());
		}

		// Token: 0x06004E36 RID: 20022
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFDSReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E37 RID: 20023 RVA: 0x00071B18 File Offset: 0x0006FD18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFDSReader.vtkFDSReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004E38 RID: 20024
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFDSReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E39 RID: 20025 RVA: 0x00071B38 File Offset: 0x0006FD38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFDSReader.vtkFDSReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06004E3A RID: 20026
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFDSReader_GetStream_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the stream from which to read the .smv file.
		/// If Stream is not nullptr, it will be used in priority from FileName
		/// </summary>
		// Token: 0x06004E3B RID: 20027 RVA: 0x00071B54 File Offset: 0x0006FD54
		public virtual vtkResourceStream GetStream()
		{
			vtkResourceStream vtkResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFDSReader.vtkFDSReader_GetStream_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResourceStream = (vtkResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResourceStream.Register(null);
				}
			}
			return vtkResourceStream;
		}

		// Token: 0x06004E3C RID: 20028
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFDSReader_GetTimeTolerance_09(HandleRef pThis);

		/// <summary>
		/// Set the absolute tolerance under which two time values are considered identical
		/// </summary>
		// Token: 0x06004E3D RID: 20029 RVA: 0x00071BC4 File Offset: 0x0006FDC4
		public virtual double GetTimeTolerance()
		{
			return vtkFDSReader.vtkFDSReader_GetTimeTolerance_09(base.GetCppThis());
		}

		// Token: 0x06004E3E RID: 20030
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFDSReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E3F RID: 20031 RVA: 0x00071BE4 File Offset: 0x0006FDE4
		public override int IsA(string type)
		{
			return vtkFDSReader.vtkFDSReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06004E40 RID: 20032
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFDSReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E41 RID: 20033 RVA: 0x00071C04 File Offset: 0x0006FE04
		public new static int IsTypeOf(string type)
		{
			return vtkFDSReader.vtkFDSReader_IsTypeOf_11(type);
		}

		// Token: 0x06004E42 RID: 20034
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFDSReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E43 RID: 20035 RVA: 0x00071C20 File Offset: 0x0006FE20
		public new vtkFDSReader NewInstance()
		{
			vtkFDSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFDSReader.vtkFDSReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFDSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004E44 RID: 20036
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFDSReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E45 RID: 20037 RVA: 0x00071C7C File Offset: 0x0006FE7C
		public new static vtkFDSReader SafeDownCast(vtkObjectBase o)
		{
			vtkFDSReader vtkFDSReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFDSReader.vtkFDSReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFDSReader = (vtkFDSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFDSReader.Register(null);
				}
			}
			return vtkFDSReader;
		}

		// Token: 0x06004E46 RID: 20038
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFDSReader_SetFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specifies the name of the .smv file to be loaded.
		/// </summary>
		// Token: 0x06004E47 RID: 20039 RVA: 0x00071CFB File Offset: 0x0006FEFB
		public virtual void SetFileName(string _arg)
		{
			vtkFDSReader.vtkFDSReader_SetFileName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06004E48 RID: 20040
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFDSReader_SetStream_16(HandleRef pThis, HandleRef stream);

		/// <summary>
		/// Set/Get the stream from which to read the .smv file.
		/// If Stream is not nullptr, it will be used in priority from FileName
		/// </summary>
		// Token: 0x06004E49 RID: 20041 RVA: 0x00071D0C File Offset: 0x0006FF0C
		public virtual void SetStream(vtkResourceStream stream)
		{
			vtkFDSReader.vtkFDSReader_SetStream_16(base.GetCppThis(), (stream == null) ? default(HandleRef) : stream.GetCppThis());
		}

		// Token: 0x06004E4A RID: 20042
		[DllImport("Kitware.VTK.IOFDS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFDSReader_SetTimeTolerance_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the absolute tolerance under which two time values are considered identical
		/// </summary>
		// Token: 0x06004E4B RID: 20043 RVA: 0x00071D3B File Offset: 0x0006FF3B
		public virtual void SetTimeTolerance(double _arg)
		{
			vtkFDSReader.vtkFDSReader_SetTimeTolerance_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000781 RID: 1921
		public new const string MRFullTypeName = "Kitware.VTK.vtkFDSReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000782 RID: 1922
		public new static readonly string MRClassNameKey = "class vtkFDSReader";
	}
}
