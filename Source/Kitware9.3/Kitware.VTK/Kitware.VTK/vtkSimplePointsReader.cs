using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimplePointsReader
	/// </summary>
	/// <remarks>
	///    Read a list of points from a file.
	///
	/// vtkSimplePointsReader is a source object that reads a list of
	/// points from a file.  Each point is specified by three
	/// floating-point values in ASCII format.  There is one point per line
	/// of the file.  A vertex cell is created for each point in the
	/// output.  This reader is meant as an example of how to write a
	/// reader in VTK.
	/// </remarks>
	// Token: 0x02000710 RID: 1808
	public class vtkSimplePointsReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012F98 RID: 77720 RVA: 0x001AC5F5 File Offset: 0x001AA7F5
		static vtkSimplePointsReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimplePointsReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimplePointsReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012F99 RID: 77721 RVA: 0x001AC61D File Offset: 0x001AA81D
		public vtkSimplePointsReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012F9A RID: 77722
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F9B RID: 77723 RVA: 0x001AC62C File Offset: 0x001AA82C
		public new static vtkSimplePointsReader New()
		{
			vtkSimplePointsReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimplePointsReader.vtkSimplePointsReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimplePointsReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F9C RID: 77724 RVA: 0x001AC680 File Offset: 0x001AA880
		public vtkSimplePointsReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimplePointsReader.vtkSimplePointsReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012F9D RID: 77725 RVA: 0x001AC6C4 File Offset: 0x001AA8C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012F9E RID: 77726
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the file from which to read points.
		/// </summary>
		// Token: 0x06012F9F RID: 77727 RVA: 0x001AC6D0 File Offset: 0x001AA8D0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSimplePointsReader.vtkSimplePointsReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012FA0 RID: 77728
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimplePointsReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FA1 RID: 77729 RVA: 0x001AC70C File Offset: 0x001AA90C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimplePointsReader.vtkSimplePointsReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012FA2 RID: 77730
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimplePointsReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FA3 RID: 77731 RVA: 0x001AC72C File Offset: 0x001AA92C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimplePointsReader.vtkSimplePointsReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012FA4 RID: 77732
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimplePointsReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FA5 RID: 77733 RVA: 0x001AC748 File Offset: 0x001AA948
		public override int IsA(string type)
		{
			return vtkSimplePointsReader.vtkSimplePointsReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012FA6 RID: 77734
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimplePointsReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FA7 RID: 77735 RVA: 0x001AC768 File Offset: 0x001AA968
		public new static int IsTypeOf(string type)
		{
			return vtkSimplePointsReader.vtkSimplePointsReader_IsTypeOf_05(type);
		}

		// Token: 0x06012FA8 RID: 77736
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FA9 RID: 77737 RVA: 0x001AC784 File Offset: 0x001AA984
		public new vtkSimplePointsReader NewInstance()
		{
			vtkSimplePointsReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimplePointsReader.vtkSimplePointsReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimplePointsReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012FAA RID: 77738
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FAB RID: 77739 RVA: 0x001AC7E0 File Offset: 0x001AA9E0
		public new static vtkSimplePointsReader SafeDownCast(vtkObjectBase o)
		{
			vtkSimplePointsReader vtkSimplePointsReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimplePointsReader.vtkSimplePointsReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimplePointsReader = (vtkSimplePointsReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimplePointsReader.Register(null);
				}
			}
			return vtkSimplePointsReader;
		}

		// Token: 0x06012FAC RID: 77740
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimplePointsReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the file from which to read points.
		/// </summary>
		// Token: 0x06012FAD RID: 77741 RVA: 0x001AC85F File Offset: 0x001AAA5F
		public virtual void SetFileName(string _arg)
		{
			vtkSimplePointsReader.vtkSimplePointsReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015EC RID: 5612
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimplePointsReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015ED RID: 5613
		public new static readonly string MRClassNameKey = "class vtkSimplePointsReader";
	}
}
