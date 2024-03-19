using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMNITagPointReader
	/// </summary>
	/// <remarks>
	///    A reader for MNI tag files.
	///
	/// The MNI .tag file format is used to store labeled points, it can
	/// store either one or two point sets.  All point sets must have the
	/// same number of points and they will share the same labels.  This
	/// file format was developed at the McConnell Brain Imaging Centre at
	/// the Montreal Neurological Institute and is used by their software.
	/// The labels are stored as a vtkStringArray in the PointData of the
	/// output dataset, which is a vtkPolyData.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMNIObjectReader vtkMNITransformReader
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class.
	/// </seealso>
	// Token: 0x0200017D RID: 381
	public class vtkMNITagPointReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060048AA RID: 18602 RVA: 0x00069DE7 File Offset: 0x00067FE7
		static vtkMNITagPointReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITagPointReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITagPointReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060048AB RID: 18603 RVA: 0x00069E0F File Offset: 0x0006800F
		public vtkMNITagPointReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060048AC RID: 18604
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048AD RID: 18605 RVA: 0x00069E20 File Offset: 0x00068020
		public new static vtkMNITagPointReader New()
		{
			vtkMNITagPointReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITagPointReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048AE RID: 18606 RVA: 0x00069E74 File Offset: 0x00068074
		public vtkMNITagPointReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMNITagPointReader.vtkMNITagPointReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060048AF RID: 18607 RVA: 0x00069EB8 File Offset: 0x000680B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060048B0 RID: 18608
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the specified file can be read.
		/// </summary>
		// Token: 0x060048B1 RID: 18609 RVA: 0x00069EC4 File Offset: 0x000680C4
		public virtual int CanReadFile(string name)
		{
			return vtkMNITagPointReader.vtkMNITagPointReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x060048B2 RID: 18610
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetComments_02(HandleRef pThis);

		/// <summary>
		/// Get any comments that are included in the file.
		/// </summary>
		// Token: 0x060048B3 RID: 18611 RVA: 0x00069EE4 File Offset: 0x000680E4
		public virtual string GetComments()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointReader.vtkMNITagPointReader_GetComments_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048B4 RID: 18612
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetDescriptiveName_03(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x060048B5 RID: 18613 RVA: 0x00069F20 File Offset: 0x00068120
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointReader.vtkMNITagPointReader_GetDescriptiveName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048B6 RID: 18614
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetFileExtensions_04(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x060048B7 RID: 18615 RVA: 0x00069F5C File Offset: 0x0006815C
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointReader.vtkMNITagPointReader_GetFileExtensions_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048B8 RID: 18616
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x060048B9 RID: 18617 RVA: 0x00069F98 File Offset: 0x00068198
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointReader.vtkMNITagPointReader_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048BA RID: 18618
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetLabelText_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the labels.  These same labels are provided in the output
		/// point sets, as the PointData data array named "LabelText".
		/// This will return nullptr if there were no labels in the file.
		/// </summary>
		// Token: 0x060048BB RID: 18619 RVA: 0x00069FD4 File Offset: 0x000681D4
		public virtual vtkStringArray GetLabelText()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_GetLabelText_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060048BC RID: 18620
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITagPointReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048BD RID: 18621 RVA: 0x0006A044 File Offset: 0x00068244
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMNITagPointReader.vtkMNITagPointReader_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060048BE RID: 18622
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITagPointReader_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048BF RID: 18623 RVA: 0x0006A064 File Offset: 0x00068264
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMNITagPointReader.vtkMNITagPointReader_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060048C0 RID: 18624
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointReader_GetNumberOfVolumes_09(HandleRef pThis);

		/// <summary>
		/// Get the number of volumes specified by the file, which will be
		/// equal to one or two.  There will be an output point set for each
		/// volume, so really, this parameter just tells you the number of
		/// outputs to expect from this reader.
		/// </summary>
		// Token: 0x060048C1 RID: 18625 RVA: 0x0006A080 File Offset: 0x00068280
		public virtual int GetNumberOfVolumes()
		{
			return vtkMNITagPointReader.vtkMNITagPointReader_GetNumberOfVolumes_09(base.GetCppThis());
		}

		// Token: 0x060048C2 RID: 18626
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetPatientIds_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the patient ids.  These are also provided in the output
		/// point sets, as the PointData data array named "PatientIds".
		/// This will return nullptr if there were no ids in the file.
		/// </summary>
		// Token: 0x060048C3 RID: 18627 RVA: 0x0006A0A0 File Offset: 0x000682A0
		public virtual vtkIntArray GetPatientIds()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_GetPatientIds_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x060048C4 RID: 18628
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetPoints_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points.  These are also provided in the first and
		/// second output ports of the reader.  This method will return
		/// nullptr if there is no data.
		/// </summary>
		// Token: 0x060048C5 RID: 18629 RVA: 0x0006A110 File Offset: 0x00068310
		public virtual vtkPoints GetPoints(int port)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_GetPoints_11(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x060048C6 RID: 18630
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetPoints_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points.  These are also provided in the first and
		/// second output ports of the reader.  This method will return
		/// nullptr if there is no data.
		/// </summary>
		// Token: 0x060048C7 RID: 18631 RVA: 0x0006A180 File Offset: 0x00068380
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_GetPoints_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x060048C8 RID: 18632
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetStructureIds_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the structure ids.  These are also provided in the output
		/// point sets, as the PointData data array named "StructureIds".
		/// This will return nullptr if there were no ids in the file.
		/// </summary>
		// Token: 0x060048C9 RID: 18633 RVA: 0x0006A1F0 File Offset: 0x000683F0
		public virtual vtkIntArray GetStructureIds()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_GetStructureIds_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x060048CA RID: 18634
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_GetWeights_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the weights.  These are also provided in the output
		/// point sets, as the PointData data array named "Weights".
		/// This will return nullptr if there were no weights in the file.
		/// </summary>
		// Token: 0x060048CB RID: 18635 RVA: 0x0006A260 File Offset: 0x00068460
		public virtual vtkDoubleArray GetWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_GetWeights_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x060048CC RID: 18636
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointReader_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048CD RID: 18637 RVA: 0x0006A2D0 File Offset: 0x000684D0
		public override int IsA(string type)
		{
			return vtkMNITagPointReader.vtkMNITagPointReader_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060048CE RID: 18638
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointReader_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048CF RID: 18639 RVA: 0x0006A2F0 File Offset: 0x000684F0
		public new static int IsTypeOf(string type)
		{
			return vtkMNITagPointReader.vtkMNITagPointReader_IsTypeOf_16(type);
		}

		// Token: 0x060048D0 RID: 18640
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048D1 RID: 18641 RVA: 0x0006A30C File Offset: 0x0006850C
		public new vtkMNITagPointReader NewInstance()
		{
			vtkMNITagPointReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITagPointReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060048D2 RID: 18642
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048D3 RID: 18643 RVA: 0x0006A368 File Offset: 0x00068568
		public new static vtkMNITagPointReader SafeDownCast(vtkObjectBase o)
		{
			vtkMNITagPointReader vtkMNITagPointReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointReader.vtkMNITagPointReader_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITagPointReader = (vtkMNITagPointReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITagPointReader.Register(null);
				}
			}
			return vtkMNITagPointReader;
		}

		// Token: 0x060048D4 RID: 18644
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointReader_SetFileName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x060048D5 RID: 18645 RVA: 0x0006A3E7 File Offset: 0x000685E7
		public virtual void SetFileName(string _arg)
		{
			vtkMNITagPointReader.vtkMNITagPointReader_SetFileName_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400074B RID: 1867
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITagPointReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400074C RID: 1868
		public new static readonly string MRClassNameKey = "class vtkMNITagPointReader";
	}
}
