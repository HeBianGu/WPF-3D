using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMNITagPointWriter
	/// </summary>
	/// <remarks>
	///    A writer for MNI tag point files.
	///
	/// The MNI .tag file format is used to store tag points, for use in
	/// either registration or labeling of data volumes.  This file
	/// format was developed at the McConnell Brain Imaging Centre at
	/// the Montreal Neurological Institute and is used by their software.
	/// Tag points can be stored for either one volume or two volumes,
	/// and this filter can take one or two inputs.  Alternatively, the
	/// points to be written can be specified by calling SetPoints().
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMNIObjectReader vtkMNITransformReader
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </seealso>
	// Token: 0x0200017E RID: 382
	public class vtkMNITagPointWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060048D6 RID: 18646 RVA: 0x0006A3F7 File Offset: 0x000685F7
		static vtkMNITagPointWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITagPointWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITagPointWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060048D7 RID: 18647 RVA: 0x0006A41F File Offset: 0x0006861F
		public vtkMNITagPointWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060048D8 RID: 18648
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048D9 RID: 18649 RVA: 0x0006A430 File Offset: 0x00068630
		public new static vtkMNITagPointWriter New()
		{
			vtkMNITagPointWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048DA RID: 18650 RVA: 0x0006A484 File Offset: 0x00068684
		public vtkMNITagPointWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMNITagPointWriter.vtkMNITagPointWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060048DB RID: 18651 RVA: 0x0006A4C8 File Offset: 0x000686C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060048DC RID: 18652
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetComments_01(HandleRef pThis);

		/// <summary>
		/// Set comments to be added to the file.
		/// </summary>
		// Token: 0x060048DD RID: 18653 RVA: 0x0006A4D4 File Offset: 0x000686D4
		public virtual string GetComments()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetComments_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048DE RID: 18654
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x060048DF RID: 18655 RVA: 0x0006A510 File Offset: 0x00068710
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048E0 RID: 18656
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x060048E1 RID: 18657 RVA: 0x0006A54C File Offset: 0x0006874C
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048E2 RID: 18658
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x060048E3 RID: 18659 RVA: 0x0006A588 File Offset: 0x00068788
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITagPointWriter.vtkMNITagPointWriter_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060048E4 RID: 18660
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetLabelText_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the labels (unless the input PointData has an
		/// array called LabelText). Labels are optional.
		/// </summary>
		// Token: 0x060048E5 RID: 18661 RVA: 0x0006A5C4 File Offset: 0x000687C4
		public virtual vtkStringArray GetLabelText()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetLabelText_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060048E6 RID: 18662
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMNITagPointWriter_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Get the MTime.
		/// </summary>
		// Token: 0x060048E7 RID: 18663 RVA: 0x0006A634 File Offset: 0x00068834
		public override ulong GetMTime()
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x060048E8 RID: 18664
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITagPointWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048E9 RID: 18665 RVA: 0x0006A654 File Offset: 0x00068854
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060048EA RID: 18666
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITagPointWriter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048EB RID: 18667 RVA: 0x0006A674 File Offset: 0x00068874
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060048EC RID: 18668
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetPatientIds_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the structure ids (unless the input PointData has
		/// an array called PatientIds).  These are optional.
		/// </summary>
		// Token: 0x060048ED RID: 18669 RVA: 0x0006A690 File Offset: 0x00068890
		public virtual vtkIntArray GetPatientIds()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetPatientIds_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060048EE RID: 18670
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetPoints_10(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the points (unless you set them as inputs).
		/// </summary>
		// Token: 0x060048EF RID: 18671 RVA: 0x0006A700 File Offset: 0x00068900
		public virtual vtkPoints GetPoints(int port)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetPoints_10(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060048F0 RID: 18672
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetPoints_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the points (unless you set them as inputs).
		/// </summary>
		// Token: 0x060048F1 RID: 18673 RVA: 0x0006A770 File Offset: 0x00068970
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetPoints_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060048F2 RID: 18674
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetStructureIds_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the structure ids (unless the input PointData has
		/// an array called StructureIds).  These are optional.
		/// </summary>
		// Token: 0x060048F3 RID: 18675 RVA: 0x0006A7E0 File Offset: 0x000689E0
		public virtual vtkIntArray GetStructureIds()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetStructureIds_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060048F4 RID: 18676
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_GetWeights_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the weights (unless the input PointData has an
		/// array called Weights).  Weights are optional.
		/// </summary>
		// Token: 0x060048F5 RID: 18677 RVA: 0x0006A850 File Offset: 0x00068A50
		public virtual vtkDoubleArray GetWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_GetWeights_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060048F6 RID: 18678
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointWriter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048F7 RID: 18679 RVA: 0x0006A8C0 File Offset: 0x00068AC0
		public override int IsA(string type)
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060048F8 RID: 18680
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointWriter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048F9 RID: 18681 RVA: 0x0006A8E0 File Offset: 0x00068AE0
		public new static int IsTypeOf(string type)
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_IsTypeOf_15(type);
		}

		// Token: 0x060048FA RID: 18682
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048FB RID: 18683 RVA: 0x0006A8FC File Offset: 0x00068AFC
		public new vtkMNITagPointWriter NewInstance()
		{
			vtkMNITagPointWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060048FC RID: 18684
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITagPointWriter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060048FD RID: 18685 RVA: 0x0006A958 File Offset: 0x00068B58
		public new static vtkMNITagPointWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMNITagPointWriter vtkMNITagPointWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITagPointWriter.vtkMNITagPointWriter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITagPointWriter = (vtkMNITagPointWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITagPointWriter.Register(null);
				}
			}
			return vtkMNITagPointWriter;
		}

		// Token: 0x060048FE RID: 18686
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetComments_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set comments to be added to the file.
		/// </summary>
		// Token: 0x060048FF RID: 18687 RVA: 0x0006A9D7 File Offset: 0x00068BD7
		public virtual void SetComments(string _arg)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetComments_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06004900 RID: 18688
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetFileName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x06004901 RID: 18689 RVA: 0x0006A9E7 File Offset: 0x00068BE7
		public virtual void SetFileName(string _arg)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetFileName_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004902 RID: 18690
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetLabelText_21(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Set the labels (unless the input PointData has an
		/// array called LabelText). Labels are optional.
		/// </summary>
		// Token: 0x06004903 RID: 18691 RVA: 0x0006A9F8 File Offset: 0x00068BF8
		public virtual void SetLabelText(vtkStringArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetLabelText_21(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06004904 RID: 18692
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetPatientIds_22(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Set the structure ids (unless the input PointData has
		/// an array called PatientIds).  These are optional.
		/// </summary>
		// Token: 0x06004905 RID: 18693 RVA: 0x0006AA28 File Offset: 0x00068C28
		public virtual void SetPatientIds(vtkIntArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetPatientIds_22(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06004906 RID: 18694
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetPoints_23(HandleRef pThis, int port, HandleRef points);

		/// <summary>
		/// Set the points (unless you set them as inputs).
		/// </summary>
		// Token: 0x06004907 RID: 18695 RVA: 0x0006AA58 File Offset: 0x00068C58
		public virtual void SetPoints(int port, vtkPoints points)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetPoints_23(base.GetCppThis(), port, (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06004908 RID: 18696
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetPoints_24(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Set the points (unless you set them as inputs).
		/// </summary>
		// Token: 0x06004909 RID: 18697 RVA: 0x0006AA88 File Offset: 0x00068C88
		public virtual void SetPoints(vtkPoints points)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetPoints_24(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0600490A RID: 18698
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetStructureIds_25(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Set the structure ids (unless the input PointData has
		/// an array called StructureIds).  These are optional.
		/// </summary>
		// Token: 0x0600490B RID: 18699 RVA: 0x0006AAB8 File Offset: 0x00068CB8
		public virtual void SetStructureIds(vtkIntArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetStructureIds_25(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0600490C RID: 18700
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITagPointWriter_SetWeights_26(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Set the weights (unless the input PointData has an
		/// array called Weights).  Weights are optional.
		/// </summary>
		// Token: 0x0600490D RID: 18701 RVA: 0x0006AAE8 File Offset: 0x00068CE8
		public virtual void SetWeights(vtkDoubleArray a)
		{
			vtkMNITagPointWriter.vtkMNITagPointWriter_SetWeights_26(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0600490E RID: 18702
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITagPointWriter_Write_27(HandleRef pThis);

		/// <summary>
		/// Write the file.
		/// </summary>
		// Token: 0x0600490F RID: 18703 RVA: 0x0006AB18 File Offset: 0x00068D18
		public override int Write()
		{
			return vtkMNITagPointWriter.vtkMNITagPointWriter_Write_27(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400074D RID: 1869
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITagPointWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400074E RID: 1870
		public new static readonly string MRClassNameKey = "class vtkMNITagPointWriter";
	}
}
