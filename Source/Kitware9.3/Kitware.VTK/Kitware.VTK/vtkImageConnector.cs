using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageConnector
	/// </summary>
	/// <remarks>
	///    Create a binary image of a sphere.
	///
	/// vtkImageConnector is a helper class for connectivity filters.
	/// It is not meant to be used directly.
	/// It implements a stack and breadth first search necessary for
	/// some connectivity filters.  Filtered axes sets the dimensionality
	/// of the neighbor comparison, and
	/// cannot be more than three dimensions.
	/// As implemented, only voxels which share faces are considered
	/// neighbors.
	/// </remarks>
	// Token: 0x02000246 RID: 582
	public class vtkImageConnector : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006C4B RID: 27723 RVA: 0x0009C37B File Offset: 0x0009A57B
		static vtkImageConnector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConnector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConnector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006C4C RID: 27724 RVA: 0x0009C3A3 File Offset: 0x0009A5A3
		public vtkImageConnector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006C4D RID: 27725
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C4E RID: 27726 RVA: 0x0009C3B4 File Offset: 0x0009A5B4
		public new static vtkImageConnector New()
		{
			vtkImageConnector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnector.vtkImageConnector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C4F RID: 27727 RVA: 0x0009C408 File Offset: 0x0009A608
		public vtkImageConnector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageConnector.vtkImageConnector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006C50 RID: 27728 RVA: 0x0009C44C File Offset: 0x0009A64C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006C51 RID: 27729
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageConnector_GetConnectedValue_01(HandleRef pThis);

		/// <summary>
		/// Values used by the MarkRegion method
		/// </summary>
		// Token: 0x06006C52 RID: 27730 RVA: 0x0009C458 File Offset: 0x0009A658
		public virtual byte GetConnectedValue()
		{
			return vtkImageConnector.vtkImageConnector_GetConnectedValue_01(base.GetCppThis());
		}

		// Token: 0x06006C53 RID: 27731
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConnector_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C54 RID: 27732 RVA: 0x0009C478 File Offset: 0x0009A678
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageConnector.vtkImageConnector_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006C55 RID: 27733
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConnector_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C56 RID: 27734 RVA: 0x0009C498 File Offset: 0x0009A698
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageConnector.vtkImageConnector_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006C57 RID: 27735
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageConnector_GetUnconnectedValue_04(HandleRef pThis);

		/// <summary>
		/// Values used by the MarkRegion method
		/// </summary>
		// Token: 0x06006C58 RID: 27736 RVA: 0x0009C4B4 File Offset: 0x0009A6B4
		public virtual byte GetUnconnectedValue()
		{
			return vtkImageConnector.vtkImageConnector_GetUnconnectedValue_04(base.GetCppThis());
		}

		// Token: 0x06006C59 RID: 27737
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnector_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C5A RID: 27738 RVA: 0x0009C4D4 File Offset: 0x0009A6D4
		public override int IsA(string type)
		{
			return vtkImageConnector.vtkImageConnector_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006C5B RID: 27739
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnector_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C5C RID: 27740 RVA: 0x0009C4F4 File Offset: 0x0009A6F4
		public new static int IsTypeOf(string type)
		{
			return vtkImageConnector.vtkImageConnector_IsTypeOf_06(type);
		}

		// Token: 0x06006C5D RID: 27741
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnector_MarkData_07(HandleRef pThis, HandleRef data, int dimensionality, IntPtr ext);

		/// <summary>
		/// Input a data of 0's and "UnconnectedValue"s. Seeds of this object are
		/// used to find connected pixels.  All pixels connected to seeds are set to
		/// ConnectedValue.  The data has to be unsigned char.
		/// </summary>
		// Token: 0x06006C5E RID: 27742 RVA: 0x0009C510 File Offset: 0x0009A710
		public void MarkData(vtkImageData data, int dimensionality, IntPtr ext)
		{
			vtkImageConnector.vtkImageConnector_MarkData_07(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), dimensionality, ext);
		}

		// Token: 0x06006C5F RID: 27743
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C60 RID: 27744 RVA: 0x0009C544 File Offset: 0x0009A744
		public new vtkImageConnector NewInstance()
		{
			vtkImageConnector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnector.vtkImageConnector_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006C61 RID: 27745
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnector_RemoveAllSeeds_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C62 RID: 27746 RVA: 0x0009C59E File Offset: 0x0009A79E
		public void RemoveAllSeeds()
		{
			vtkImageConnector.vtkImageConnector_RemoveAllSeeds_10(base.GetCppThis());
		}

		// Token: 0x06006C63 RID: 27747
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnector_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C64 RID: 27748 RVA: 0x0009C5B0 File Offset: 0x0009A7B0
		public new static vtkImageConnector SafeDownCast(vtkObjectBase o)
		{
			vtkImageConnector vtkImageConnector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnector.vtkImageConnector_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConnector = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConnector.Register(null);
				}
			}
			return vtkImageConnector;
		}

		// Token: 0x06006C65 RID: 27749
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnector_SetConnectedValue_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Values used by the MarkRegion method
		/// </summary>
		// Token: 0x06006C66 RID: 27750 RVA: 0x0009C62F File Offset: 0x0009A82F
		public virtual void SetConnectedValue(byte _arg)
		{
			vtkImageConnector.vtkImageConnector_SetConnectedValue_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C67 RID: 27751
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnector_SetUnconnectedValue_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Values used by the MarkRegion method
		/// </summary>
		// Token: 0x06006C68 RID: 27752 RVA: 0x0009C63F File Offset: 0x0009A83F
		public virtual void SetUnconnectedValue(byte _arg)
		{
			vtkImageConnector.vtkImageConnector_SetUnconnectedValue_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000981 RID: 2433
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConnector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000982 RID: 2434
		public new static readonly string MRClassNameKey = "class vtkImageConnector";
	}
}
