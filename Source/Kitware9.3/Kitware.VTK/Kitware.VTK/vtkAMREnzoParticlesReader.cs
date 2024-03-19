using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMREnzoParticlesReader
	///
	///
	///  A concrete instance of the vtkAMRBaseParticlesReader which provides
	///  functionality for loading ENZO AMR particle datasets from ENZO.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkAMRBaseParticlesReader
	/// </seealso>
	// Token: 0x02000226 RID: 550
	public class vtkAMREnzoParticlesReader : vtkAMRBaseParticlesReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006785 RID: 26501 RVA: 0x00095777 File Offset: 0x00093977
		static vtkAMREnzoParticlesReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMREnzoParticlesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMREnzoParticlesReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006786 RID: 26502 RVA: 0x0009579F File Offset: 0x0009399F
		public vtkAMREnzoParticlesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006787 RID: 26503
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMREnzoParticlesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006788 RID: 26504 RVA: 0x000957B0 File Offset: 0x000939B0
		public new static vtkAMREnzoParticlesReader New()
		{
			vtkAMREnzoParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMREnzoParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006789 RID: 26505 RVA: 0x00095804 File Offset: 0x00093A04
		public vtkAMREnzoParticlesReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600678A RID: 26506 RVA: 0x00095848 File Offset: 0x00093A48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600678B RID: 26507
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMREnzoParticlesReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600678C RID: 26508 RVA: 0x00095854 File Offset: 0x00093A54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600678D RID: 26509
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMREnzoParticlesReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600678E RID: 26510 RVA: 0x00095874 File Offset: 0x00093A74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600678F RID: 26511
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoParticlesReader_GetParticleType_03(HandleRef pThis);

		/// <summary>
		/// Returns the requested particle type.
		/// </summary>
		// Token: 0x06006790 RID: 26512 RVA: 0x00095890 File Offset: 0x00093A90
		public virtual int GetParticleType()
		{
			return vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_GetParticleType_03(base.GetCppThis());
		}

		// Token: 0x06006791 RID: 26513
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoParticlesReader_GetTotalNumberOfParticles_04(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseParticlesReader::GetTotalNumberOfParticles.
		/// </summary>
		// Token: 0x06006792 RID: 26514 RVA: 0x000958B0 File Offset: 0x00093AB0
		public override int GetTotalNumberOfParticles()
		{
			return vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_GetTotalNumberOfParticles_04(base.GetCppThis());
		}

		// Token: 0x06006793 RID: 26515
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoParticlesReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006794 RID: 26516 RVA: 0x000958D0 File Offset: 0x00093AD0
		public override int IsA(string type)
		{
			return vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006795 RID: 26517
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoParticlesReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006796 RID: 26518 RVA: 0x000958F0 File Offset: 0x00093AF0
		public new static int IsTypeOf(string type)
		{
			return vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_IsTypeOf_06(type);
		}

		// Token: 0x06006797 RID: 26519
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMREnzoParticlesReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006798 RID: 26520 RVA: 0x0009590C File Offset: 0x00093B0C
		public new vtkAMREnzoParticlesReader NewInstance()
		{
			vtkAMREnzoParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMREnzoParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006799 RID: 26521
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMREnzoParticlesReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600679A RID: 26522 RVA: 0x00095968 File Offset: 0x00093B68
		public new static vtkAMREnzoParticlesReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMREnzoParticlesReader vtkAMREnzoParticlesReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMREnzoParticlesReader = (vtkAMREnzoParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMREnzoParticlesReader.Register(null);
				}
			}
			return vtkAMREnzoParticlesReader;
		}

		// Token: 0x0600679B RID: 26523
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMREnzoParticlesReader_SetParticleType_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Returns the requested particle type.
		/// </summary>
		// Token: 0x0600679C RID: 26524 RVA: 0x000959E7 File Offset: 0x00093BE7
		public virtual void SetParticleType(int _arg)
		{
			vtkAMREnzoParticlesReader.vtkAMREnzoParticlesReader_SetParticleType_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000933 RID: 2355
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMREnzoParticlesReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000934 RID: 2356
		public new static readonly string MRClassNameKey = "class vtkAMREnzoParticlesReader";
	}
}
