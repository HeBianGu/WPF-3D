using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFacetReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in Facet format
	///
	/// vtkFacetReader creates a poly data dataset. It reads ASCII files
	/// stored in Facet format
	///
	/// The facet format looks like this:
	/// FACET FILE ...
	/// nparts
	/// Part 1 name
	/// 0
	/// npoints 0 0
	/// p1x p1y p1z
	/// p2x p2y p2z
	/// ...
	/// 1
	/// Part 1 name
	/// ncells npointspercell
	/// p1c1 p2c1 p3c1 ... pnc1 materialnum partnum
	/// p1c2 p2c2 p3c2 ... pnc2 materialnum partnum
	/// ...
	/// </remarks>
	// Token: 0x02000609 RID: 1545
	public class vtkFacetReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010C54 RID: 68692 RVA: 0x00176487 File Offset: 0x00174687
		static vtkFacetReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFacetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFacetReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010C55 RID: 68693 RVA: 0x001764AF File Offset: 0x001746AF
		public vtkFacetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010C56 RID: 68694
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C57 RID: 68695 RVA: 0x001764C0 File Offset: 0x001746C0
		public new static vtkFacetReader New()
		{
			vtkFacetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFacetReader.vtkFacetReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFacetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C58 RID: 68696 RVA: 0x00176514 File Offset: 0x00174714
		public vtkFacetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFacetReader.vtkFacetReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010C59 RID: 68697 RVA: 0x00176558 File Offset: 0x00174758
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010C5A RID: 68698
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFacetReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Specify file name of Facet datafile to read
		/// </summary>
		// Token: 0x06010C5B RID: 68699 RVA: 0x00176564 File Offset: 0x00174764
		public static int CanReadFile(string filename)
		{
			return vtkFacetReader.vtkFacetReader_CanReadFile_01(filename);
		}

		// Token: 0x06010C5C RID: 68700
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify file name of Facet datafile to read
		/// </summary>
		// Token: 0x06010C5D RID: 68701 RVA: 0x00176580 File Offset: 0x00174780
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkFacetReader.vtkFacetReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010C5E RID: 68702
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFacetReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C5F RID: 68703 RVA: 0x001765BC File Offset: 0x001747BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFacetReader.vtkFacetReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010C60 RID: 68704
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFacetReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C61 RID: 68705 RVA: 0x001765DC File Offset: 0x001747DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFacetReader.vtkFacetReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010C62 RID: 68706
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFacetReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C63 RID: 68707 RVA: 0x001765F8 File Offset: 0x001747F8
		public override int IsA(string type)
		{
			return vtkFacetReader.vtkFacetReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06010C64 RID: 68708
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFacetReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C65 RID: 68709 RVA: 0x00176618 File Offset: 0x00174818
		public new static int IsTypeOf(string type)
		{
			return vtkFacetReader.vtkFacetReader_IsTypeOf_06(type);
		}

		// Token: 0x06010C66 RID: 68710
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C67 RID: 68711 RVA: 0x00176634 File Offset: 0x00174834
		public new vtkFacetReader NewInstance()
		{
			vtkFacetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFacetReader.vtkFacetReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFacetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010C68 RID: 68712
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C69 RID: 68713 RVA: 0x00176690 File Offset: 0x00174890
		public new static vtkFacetReader SafeDownCast(vtkObjectBase o)
		{
			vtkFacetReader vtkFacetReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFacetReader.vtkFacetReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFacetReader = (vtkFacetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFacetReader.Register(null);
				}
			}
			return vtkFacetReader;
		}

		// Token: 0x06010C6A RID: 68714
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFacetReader_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of Facet datafile to read
		/// </summary>
		// Token: 0x06010C6B RID: 68715 RVA: 0x0017670F File Offset: 0x0017490F
		public virtual void SetFileName(string _arg)
		{
			vtkFacetReader.vtkFacetReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400136C RID: 4972
		public new const string MRFullTypeName = "Kitware.VTK.vtkFacetReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400136D RID: 4973
		public new static readonly string MRClassNameKey = "class vtkFacetReader";
	}
}
