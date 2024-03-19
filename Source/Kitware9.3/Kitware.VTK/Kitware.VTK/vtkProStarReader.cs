using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProStarReader
	/// </summary>
	/// <remarks>
	///    Reads geometry in proSTAR (STARCD) file format.
	///
	/// vtkProStarReader creates an unstructured grid dataset.
	/// It reads .cel/.vrt files stored in proSTAR (STARCD) ASCII format.
	///
	/// @par Thanks:
	/// Reader written by Mark Olesen
	///
	/// </remarks>
	// Token: 0x0200020E RID: 526
	public class vtkProStarReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006494 RID: 25748 RVA: 0x00090B92 File Offset: 0x0008ED92
		static vtkProStarReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProStarReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProStarReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006495 RID: 25749 RVA: 0x00090BBA File Offset: 0x0008EDBA
		public vtkProStarReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006496 RID: 25750
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProStarReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006497 RID: 25751 RVA: 0x00090BC8 File Offset: 0x0008EDC8
		public new static vtkProStarReader New()
		{
			vtkProStarReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProStarReader.vtkProStarReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006498 RID: 25752 RVA: 0x00090C1C File Offset: 0x0008EE1C
		public vtkProStarReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProStarReader.vtkProStarReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006499 RID: 25753 RVA: 0x00090C60 File Offset: 0x0008EE60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600649A RID: 25754
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProStarReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the file name prefix of the cel/vrt files to read.
		/// The reader will try to open FileName.cel and FileName.vrt files.
		/// </summary>
		// Token: 0x0600649B RID: 25755 RVA: 0x00090C6C File Offset: 0x0008EE6C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkProStarReader.vtkProStarReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600649C RID: 25756
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProStarReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600649D RID: 25757 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProStarReader.vtkProStarReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600649E RID: 25758
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProStarReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600649F RID: 25759 RVA: 0x00090CC8 File Offset: 0x0008EEC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProStarReader.vtkProStarReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060064A0 RID: 25760
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProStarReader_GetScaleFactor_04(HandleRef pThis);

		/// <summary>
		/// The proSTAR files are often in millimeters.
		/// Specify an alternative scaling factor.
		/// </summary>
		// Token: 0x060064A1 RID: 25761 RVA: 0x00090CE4 File Offset: 0x0008EEE4
		public virtual double GetScaleFactor()
		{
			return vtkProStarReader.vtkProStarReader_GetScaleFactor_04(base.GetCppThis());
		}

		// Token: 0x060064A2 RID: 25762
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProStarReader_GetScaleFactorMaxValue_05(HandleRef pThis);

		/// <summary>
		/// The proSTAR files are often in millimeters.
		/// Specify an alternative scaling factor.
		/// </summary>
		// Token: 0x060064A3 RID: 25763 RVA: 0x00090D04 File Offset: 0x0008EF04
		public virtual double GetScaleFactorMaxValue()
		{
			return vtkProStarReader.vtkProStarReader_GetScaleFactorMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060064A4 RID: 25764
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProStarReader_GetScaleFactorMinValue_06(HandleRef pThis);

		/// <summary>
		/// The proSTAR files are often in millimeters.
		/// Specify an alternative scaling factor.
		/// </summary>
		// Token: 0x060064A5 RID: 25765 RVA: 0x00090D24 File Offset: 0x0008EF24
		public virtual double GetScaleFactorMinValue()
		{
			return vtkProStarReader.vtkProStarReader_GetScaleFactorMinValue_06(base.GetCppThis());
		}

		// Token: 0x060064A6 RID: 25766
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProStarReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064A7 RID: 25767 RVA: 0x00090D44 File Offset: 0x0008EF44
		public override int IsA(string type)
		{
			return vtkProStarReader.vtkProStarReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060064A8 RID: 25768
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProStarReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064A9 RID: 25769 RVA: 0x00090D64 File Offset: 0x0008EF64
		public new static int IsTypeOf(string type)
		{
			return vtkProStarReader.vtkProStarReader_IsTypeOf_08(type);
		}

		// Token: 0x060064AA RID: 25770
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProStarReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064AB RID: 25771 RVA: 0x00090D80 File Offset: 0x0008EF80
		public new vtkProStarReader NewInstance()
		{
			vtkProStarReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProStarReader.vtkProStarReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060064AC RID: 25772
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProStarReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060064AD RID: 25773 RVA: 0x00090DDC File Offset: 0x0008EFDC
		public new static vtkProStarReader SafeDownCast(vtkObjectBase o)
		{
			vtkProStarReader vtkProStarReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProStarReader.vtkProStarReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProStarReader = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProStarReader.Register(null);
				}
			}
			return vtkProStarReader;
		}

		// Token: 0x060064AE RID: 25774
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProStarReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the file name prefix of the cel/vrt files to read.
		/// The reader will try to open FileName.cel and FileName.vrt files.
		/// </summary>
		// Token: 0x060064AF RID: 25775 RVA: 0x00090E5B File Offset: 0x0008F05B
		public virtual void SetFileName(string _arg)
		{
			vtkProStarReader.vtkProStarReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060064B0 RID: 25776
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProStarReader_SetScaleFactor_13(HandleRef pThis, double _arg);

		/// <summary>
		/// The proSTAR files are often in millimeters.
		/// Specify an alternative scaling factor.
		/// </summary>
		// Token: 0x060064B1 RID: 25777 RVA: 0x00090E6B File Offset: 0x0008F06B
		public virtual void SetScaleFactor(double _arg)
		{
			vtkProStarReader.vtkProStarReader_SetScaleFactor_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008F3 RID: 2291
		public new const string MRFullTypeName = "Kitware.VTK.vtkProStarReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008F4 RID: 2292
		public new static readonly string MRClassNameKey = "class vtkProStarReader";

		/// <summary>
		/// The type of material represented by the cell
		/// </summary>
		// Token: 0x0200020F RID: 527
		public enum cellType
		{
			/// <summary>enum member</summary>
			// Token: 0x040008F6 RID: 2294
			starcdBaffleType = 3,
			/// <summary>enum member</summary>
			// Token: 0x040008F7 RID: 2295
			starcdFluidType = 1,
			/// <summary>enum member</summary>
			// Token: 0x040008F8 RID: 2296
			starcdLineType = 5,
			/// <summary>enum member</summary>
			// Token: 0x040008F9 RID: 2297
			starcdPointType,
			/// <summary>enum member</summary>
			// Token: 0x040008FA RID: 2298
			starcdShellType = 4,
			/// <summary>enum member</summary>
			// Token: 0x040008FB RID: 2299
			starcdSolidType = 2
		}

		/// <summary>
		/// The primitive cell shape
		/// </summary>
		// Token: 0x02000210 RID: 528
		public enum shapeType
		{
			/// <summary>enum member</summary>
			// Token: 0x040008FD RID: 2301
			starcdHex = 11,
			/// <summary>enum member</summary>
			// Token: 0x040008FE RID: 2302
			starcdLine = 2,
			/// <summary>enum member</summary>
			// Token: 0x040008FF RID: 2303
			starcdPoint = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000900 RID: 2304
			starcdPoly = 255,
			/// <summary>enum member</summary>
			// Token: 0x04000901 RID: 2305
			starcdPrism = 12,
			/// <summary>enum member</summary>
			// Token: 0x04000902 RID: 2306
			starcdPyr = 14,
			/// <summary>enum member</summary>
			// Token: 0x04000903 RID: 2307
			starcdShell = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000904 RID: 2308
			starcdTet = 13
		}
	}
}
